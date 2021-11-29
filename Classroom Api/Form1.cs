using Google;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Classroom.v1;
using Google.Apis.Classroom.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace Classroom_Api
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private class Links //Links classe
        {
            public string Nome { get; set; }
            public string Link { get; set; }
            public override string ToString()
            {
                return Nome + "-" + Link;
            }
            public Links(string nome, string link)
            {
                this.Nome = nome;
                this.Link = link;
            }
        }

        private class Corsi //Corsi classroom classe 
        {
            public string Nome { get; set; }
            public string Id { get; set; }
            public override string ToString()
            {
                return Nome + "-" + Id;
            }
            public Corsi(string nome, string id)
            {
                this.Nome = nome;
                this.Id = id;
            }

        }

        private class Lavori //Compiti classroom classe
        {
            public string clasrId { get; set; }
            public string Nome { get; set; }
            public string Id { get; set; }
            public string Titolo { get; set; }
            public string Descrizione { get; set; }
            public override string ToString()
            {
                return clasrId + "-" + Nome + "-" + Id + "-" + Titolo + "-" + Descrizione;
            }
            public Lavori(string clasid, string id, string titolo, string descrizione)
            {
                this.clasrId = clasid;
                this.Id = id;
                this.Titolo = titolo;
                this.Descrizione = descrizione;
            }

        }

        private class ClassroomScopes
        {
            // If modifying these scopes, delete your previously saved credentials
            // at ~/.credentials/classroom.googleapis.com-dotnet-quickstart.json
            public static string[] Scopes = {
                ClassroomService.Scope.ClassroomCourseworkStudents,
                ClassroomService.Scope.ClassroomCourseworkStudentsReadonly,
                ClassroomService.Scope.ClassroomCourseworkMe,
                ClassroomService.Scope.ClassroomCourseworkMeReadonly,
                ClassroomService.Scope.ClassroomCourses,
                ClassroomService.Scope.ClassroomCoursesReadonly
            };

            public static string ApplicationName = "Classroom API .NET Quickstart";
        }

        private ClassroomService Servizio()
        {
            UserCredential credential;

            using (FileStream stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    ClassroomScopes.Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                //MessageBox.Show("Credential file saved to: " + credPath);
            }

            // Create Classroom API service.
            ClassroomService service = new ClassroomService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ClassroomScopes.ApplicationName,
            });
            return service;
        }

        private void CbBoxMaterie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbClassromm.SelectedIndex < 0)
                return;
            if (CmbClassromm.SelectedItem == null)
                return;
            kryptonLabelInfo.Text = "";
            lbCompiti.Items.Clear();
            Corsi corso = CmbClassromm.SelectedItem as Corsi;
            string courseId = corso.Id;
            Course course = default;
            try
            {
                course = Servizio().Courses.Get(courseId).Execute();
                kryptonLabelInfo.Text = $"Corso con ID '{courseId}' Trovato!.\n Descrizione: {course.DescriptionHeading}\n Id del proprietario: {course.OwnerId}\n";
            }
            catch (GoogleApiException error)
            {
                if (error.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    kryptonLabelInfo.Text = $"Corso con ID '{courseId}' non trovato.\n";
                }
                else
                {
                    throw error;
                }
            }
            string pageToken = null;
            List<CourseWork> classWorkList = new List<CourseWork>();
            do
            {
                CoursesResource.CourseWorkResource.ListRequest request = Servizio().Courses.CourseWork.List(courseId);
                request.PageSize = 100;
                request.PageToken = pageToken;
                ListCourseWorkResponse response = request.Execute();
                if (response.CourseWork != null)
                {
                    classWorkList.AddRange(response.CourseWork);
                }
                pageToken = response.NextPageToken;
            } while (pageToken != null);
            foreach (CourseWork work in classWorkList)
            {
                lbCompiti.Items.Add(new Lavori(courseId, work.Id, work.Title, work.Description));
            }
        }

        private void listBoxCompiti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCompiti.SelectedIndex < 0)
                return;
            if (lbCompiti.SelectedItem == null)
                return;
            cbAllegati.Items.Clear();
            Lavori Lav = lbCompiti.SelectedItem as Lavori;
            CourseWork Materiali = Servizio().Courses.CourseWork.Get(Lav.clasrId, Lav.Id).Execute();
            if (Lav != null)
            {
                if (Materiali.Materials != null)
                {
                    foreach (Material material in Materiali.Materials)
                    {
                        SharedDriveFile sharedDriveFile = material.DriveFile;
                        Link link = material.Link;
                        YouTubeVideo youTubeVideo = material.YoutubeVideo;
                        if(sharedDriveFile != null)
                        {
                            cbAllegati.Items.Add(new Links(sharedDriveFile.DriveFile.Title, sharedDriveFile.DriveFile.AlternateLink));
                        }
                        if (link != null)
                        {
                            cbAllegati.Items.Add(new Links(link.Title, link.Url));
                        }
                        if (youTubeVideo != null)
                        {
                            cbAllegati.Items.Add(new Links(youTubeVideo.Title, youTubeVideo.AlternateLink));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nessuno file/link/video da visualizzare");
                    webBrowser1.Navigate("");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)//Ottieni clasroom corsi
        {
            CoursesResource.ListRequest request = Servizio().Courses.List();
            request.PageSize = 10;

            // List courses.
            ListCoursesResponse response = request.Execute();

            if (response.Courses != null && response.Courses.Count > 0)
            {
                foreach (Course course in response.Courses)
                {
                    CmbClassromm.Items.Add(new Corsi(course.Name, course.Id));
                }
            }
            else
            {
                MessageBox.Show("Nessun corso trovato");
            }
        }

        private void cbAllegati_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAllegati.SelectedIndex < 0)
                return;
            if (cbAllegati.SelectedItem == null)
                return;
            Links i = cbAllegati.SelectedItem as Links;
            if (i != null)
            {
                webBrowser1.Navigate(new Uri(i.Link.ToString()));
                webBrowser1.ScriptErrorsSuppressed = true;
            }
        }
    }
}
