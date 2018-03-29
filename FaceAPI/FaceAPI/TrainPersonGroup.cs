using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FaceAPI
{
    public partial class TrainPersonGroup : Form
    {
        public TrainPersonGroup()
        {
            InitializeComponent();
        }

        string str_FaceImageLocation = "";
        string str_DetectImageLocation = "";

        private void button_CreateAPersonGroup_Click(object sender, EventArgs e)
        {
            CreateAPersonGroup();
        }

        private async void CreateAPersonGroup()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = GeneralConstants.str_API_URL + "/face/v1.0/persongroups/" + textBox_PersonGroupId.Text + "?" + queryString;

            HttpResponseMessage response;

            // Request body
            PersonGroup personGroup1 = new PersonGroup
            {
                name = textBox_PersonGroupName.Text,
                userData = textBox_PersonGroupUserData.Text
            };
            string json = JsonConvert.SerializeObject(personGroup1, Formatting.Indented);
            byte[] byteData = Encoding.UTF8.GetBytes(json);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PutAsync(uri, content);
                textBox_CreateAPersonGroupResult.Text = response.StatusCode.ToString();
            }
        }

        private void button_CreateAPerson_Click(object sender, EventArgs e)
        {
            CreateAPerson();
        }

        async void CreateAPerson()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = GeneralConstants.str_API_URL + "/face/v1.0/persongroups/" + textBox_PersonGroupId.Text + "/persons?" + queryString;

            HttpResponseMessage response;

            // Request body
            Person person1 = new Person
            {
                name = textBox_personName.Text,
                userData = textBox_personUserData.Text
            };
            string json = JsonConvert.SerializeObject(person1, Formatting.Indented);
            byte[] byteData = Encoding.UTF8.GetBytes(json);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
                json = await response.Content.ReadAsStringAsync();
                PersonId personid = JsonConvert.DeserializeObject<PersonId>(json);
                textBox_CreateAPersonResult.Text = personid.personId;
            }

        }

        private void button_AddAPersonFace_Click(object sender, EventArgs e)
        {
            AddAPersonFace();
        }

        private void button_ChooseAPersonFace_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "所有文件(*.*)|*.*|JPG文件(*.jpg)|*.jpg|JPEG文件(*.jpeg)|*.jpeg|PNG文件(*.png)|*.png|BMP文件(*.bmp)|*.bmp|GIF文件(*.gif)|*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                str_FaceImageLocation = opf.FileName;
                pictureBox_ChooseFaceImage.Image = Image.FromFile(opf.FileName);
            }
        }

        async void AddAPersonFace()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            // Request parameters
            queryString["userData"] = "";
            queryString["targetFace"] = "";
            var uri = GeneralConstants.str_API_URL + "/face/v1.0/persongroups/" + textBox_PersonGroupId.Text + "/persons/" + textBox_CreateAPersonResult.Text + "/persistedFaces?" + queryString;

            HttpResponseMessage response;

            // Request body
            byte[] byteData;
            byteData = ImageHelper.SetImageToByteArray(str_FaceImageLocation);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(uri, content);
                textBox_AddAPersonFaceResult.Text = response.StatusCode.ToString();
            }

        }

        private void button_TrainPersonGroup_Click(object sender, EventArgs e)
        {
            TrainPersonGroupss();
        }

        async void TrainPersonGroupss()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = GeneralConstants.str_API_URL + "/face/v1.0/persongroups/" + textBox_PersonGroupId.Text + "/train?" + queryString;

            HttpResponseMessage response;

            // Request body
            byte[] byteData = Encoding.UTF8.GetBytes("");

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
                textBox_TrainPersonGroupResult.Text = response.StatusCode.ToString();
            }

        }

        private void button_Detect_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "所有文件(*.*)|*.*|JPG文件(*.jpg)|*.jpg|JPEG文件(*.jpeg)|*.jpeg|PNG文件(*.png)|*.png|BMP文件(*.bmp)|*.bmp|GIF文件(*.gif)|*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                str_DetectImageLocation = opf.FileName;
                pictureBox_Detect.Image = Image.FromFile(opf.FileName);
                textBox_DetectResult.Text = textBox_IdentifyResult.Text = "";

                Detect();
            }
        }

        async void Detect()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            // Request parameters
            //Optional
            queryString["returnFaceId"] = "true";
            queryString["returnFaceLandmarks"] = "false";
            queryString["returnFaceAttributes"] = "age,gender,headPose,smile,facialHair,glasses";//"returnFaceAttributes=age,gender". Supported face attributes include age, gender, headPose, smile, facialHair, and glasses
            var uri = GeneralConstants.str_API_URL + "/face/v1.0/detect?" + queryString;

            HttpResponseMessage response;

            // Request body
            byte[] byteData;
            byteData = ImageHelper.SetImageToByteArray(str_DetectImageLocation);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(uri, content);

                textBox_DetectResult.Text = await response.Content.ReadAsStringAsync();
            }

        }

        private void button_Identify_Click(object sender, EventArgs e)
        {
            Identify();
        }

        async void Identify()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = GeneralConstants.str_API_URL + "/face/v1.0/identify?" + queryString;

            HttpResponseMessage response;

            // Request body
            FaceClass[] faces = JsonConvert.DeserializeObject<FaceClass[]>(textBox_DetectResult.Text);
            if (faces.Length == 0)
                return;
            List<string> facesIds = new List<string>();
            foreach(FaceClass fc in faces)
            {
                facesIds.Add(fc.faceId);
            }
            IdentifyJson identifyJson = new IdentifyJson
            {
                personGroupId = textBox_PersonGroupId.Text,
                faceIds = facesIds.ToArray(),
                maxNumOfCandidatesReturned = 1,
                confidenceThreshold = trackBar_confidenceThreshold.Value / 100.0
            };
            string json = JsonConvert.SerializeObject(identifyJson, Formatting.Indented);
            byte[] byteData = Encoding.UTF8.GetBytes(json);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);

                json = await response.Content.ReadAsStringAsync();
                IdentifyResult[] ir = JsonConvert.DeserializeObject<IdentifyResult[]>(json);
                if(ir.Length > 0)
                {
                    for(int i = 0; i < ir.Length; i++)
                    {
                        if(ir[i].candidates.Length > 0)
                        {
                            string str_Name = await QueryPersonNameByPersonId(ir[i].candidates[0].personId);
                            textBox_IdentifyResult.Text += "姓名：" + str_Name + "\r\n可信度" + ir[i].candidates[0].confidence + "\r\n";
                        }
                        else
                        {
                            textBox_IdentifyResult.Text = "No candidates";
                        }
                    }
                }
                else
                {
                    textBox_IdentifyResult.Text = "Can not indentify from known faces";
                }
            }

        }

        async Task<string> QueryPersonNameByPersonId(string personId)
        {
            string strName = "";
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);
            var uri = GeneralConstants.str_API_URL + "/face/v1.0/persongroups/" + textBox_PersonGroupId.Text + "/persons/" + personId + "?" + queryString;
            var response = await client.GetAsync(uri);

            string json = await response.Content.ReadAsStringAsync();
            Personss pss = JsonConvert.DeserializeObject<Personss>(json);
            strName = pss.name;

            return strName;
        }

        private void trackBar_confidenceThreshold_Scroll(object sender, EventArgs e)
        {
            label_confidenceThreshold.Text = (trackBar_confidenceThreshold.Value / 100.0).ToString();
        }

    }
}
