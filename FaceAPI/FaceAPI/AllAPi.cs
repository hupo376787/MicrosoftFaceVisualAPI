using System;
using System.Drawing;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Threading;

namespace FaceAPI
{
    public partial class AllAPi : Form
    {
        public AllAPi()
        {
            InitializeComponent();
        }

        string str_Detect_Result = "";

        private void AllAPi_Load(object sender, EventArgs e)
        {
            textBox_NetImageUrl.Enabled = false;
            textBox_NetImageUrl1.Enabled = false;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Output.Text = "";
        }

        #region PersonGroup
        private void button_ListPersonGroups_Click(object sender, EventArgs e)
        {
            ListPersonGroupsAsync();
        }

        async void ListPersonGroupsAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            // Request parameters
            queryString["start"] = textBox_Start.Text;
            queryString["top"] = textBox_Top.Text;
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups?" + queryString;

            var response = await client.GetAsync(uri);
            string json = await response.Content.ReadAsStringAsync();
            textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
        }

        private void button_RandomOnePersonGroupId_Click(object sender, EventArgs e)
        {
            textBox_PersonGroupId.Text = Guid.NewGuid().ToString();
        }

        private void button_CreateaPersonGroup_Click(object sender, EventArgs e)
        {
            CreateaPersonGroupAsync();
        }

        async void CreateaPersonGroupAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox_PersonGroupId.Text + "?" + queryString;

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
                json = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    textBox_Output.Text = "Create " + textBox_PersonGroupId.Text + " successfully";
                else
                    textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
            }
        }

        private void button_DeleteaPersonGroup_Click(object sender, EventArgs e)
        {
            DeleteaPersonGroupAsync();
        }

        async void DeleteaPersonGroupAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox__DeleteaPersonGroupId.Text + "?" + queryString;
            var response = await client.DeleteAsync(uri);
            string json = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                textBox_Output.Text = "Delete " + textBox__DeleteaPersonGroupId.Text + " successfully";
            else
                textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
        }

        private void button_GetaPersonGroup_Click(object sender, EventArgs e)
        {
            GetaPersonGroupAsync();
        }

        async void GetaPersonGroupAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox_GetaPersonGroupId.Text + "?" + queryString;
            var response = await client.GetAsync(uri);
            string json = await response.Content.ReadAsStringAsync();
            textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
        }

        private void button_GetPersonGroupTrainingStatus_Click(object sender, EventArgs e)
        {
            GetPersonGroupTrainingStatusAsync();
        }

        async void GetPersonGroupTrainingStatusAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox_GetPersonGroupTrainingStatusId.Text + "/training?" + queryString;
            var response = await client.GetAsync(uri);
            string json = await response.Content.ReadAsStringAsync();
            textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
        }

        private void button_TrainPersonGroup_Click(object sender, EventArgs e)
        {
            TrainPersonGroupAsync();
        }

        async void TrainPersonGroupAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox_TrainPersonGroupId.Text + "/train?" + queryString;

            HttpResponseMessage response;

            // Request body
            byte[] byteData = Encoding.UTF8.GetBytes("");

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
                string json = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                    textBox_Output.Text = "Train Group " + textBox_TrainPersonGroupId.Text + " successfully";
                else
                    textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
            }

        }

        private void button_UpdateaPersonGroup_Click(object sender, EventArgs e)
        {
            UpdateaPersonGroupAsync();
        }

        async void UpdateaPersonGroupAsync()
        {
            //var client = new HttpClient();
            //var queryString = HttpUtility.ParseQueryString(string.Empty);

            //// Request headers
            //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            //var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox_UpdateaPersonGroupId.Text + "?" + queryString;
            //HttpResponseMessage response;

            //// Request body
            //PersonGroup personGroup1 = new PersonGroup
            //{
            //    name = textBox_UpdateaPersonGroupName.Text,
            //    userData = textBox__UpdateaPersonGroupUserData.Text
            //};
            //string json = JsonConvert.SerializeObject(personGroup1, Formatting.Indented);
            //byte[] byteData = Encoding.UTF8.GetBytes(json);

            //using (var content = new ByteArrayContent(byteData))
            //{
            //    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //    response = await client.PutAsync(uri, content);
            //    json = await response.Content.ReadAsStringAsync();
            //    if (response.StatusCode == System.Net.HttpStatusCode.OK)
            //        textBox_Output.Text = "Update " + textBox_UpdateaPersonGroupId.Text + " successfully";
            //    else
            //        textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
            //}
        }
        #endregion

        #region Person
        private void button_CreateaPerson_Click(object sender, EventArgs e)
        {
            CreateaPersonAsync();
        }

        async void CreateaPersonAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox_CreateaPersonGroupId.Text + "/persons?" + queryString;

            HttpResponseMessage response;

            // Request body
            Person person1 = new Person
            {
                name = textBox__CreateaPersonName.Text,
                userData = textBox__CreateaPersonUserData.Text
            };
            string json = JsonConvert.SerializeObject(person1, Formatting.Indented);
            byte[] byteData = Encoding.UTF8.GetBytes(json);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
                json = await response.Content.ReadAsStringAsync();
                textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
            }
        }

        private void radioButton_LocalImage_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_LocalImage.Checked)
                textBox_NetImageUrl.Enabled = false;
            else
                textBox_NetImageUrl.Enabled = true;
        }

        private void radioButton_NetImage_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_NetImage.Checked)
                button_ChooseAPersonFace.Enabled = false;
            else
                button_ChooseAPersonFace.Enabled = true;
        }

        private void button_ChooseAPersonFace_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "所有文件(*.*)|*.*|JPG文件(*.jpg)|*.jpg|JPEG文件(*.jpeg)|*.jpeg|PNG文件(*.png)|*.png|BMP文件(*.bmp)|*.bmp|GIF文件(*.gif)|*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_ChooseFaceImage.Image = Image.FromFile(opf.FileName);
                pictureBox_ChooseFaceImage.Tag = opf.FileName;
            }
        }

        private void button_AddAPersonFace_Click(object sender, EventArgs e)
        {
            AddAPersonFaceAsync();
        }

        async void AddAPersonFaceAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            // Request parameters
            queryString["userData"] = "";
            queryString["targetFace"] = "";
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox_AddAPersonFacePersonGroupId.Text + "/persons/" + textBox_AddAPersonFacePersonId.Text + "/persistedFaces?" + queryString;

            HttpResponseMessage response = null;
            // Request body
            byte[] byteData;
            string json = "";
            if (radioButton_LocalImage.Checked)
            {
                byteData = ImageHelper.SetImageToByteArray(pictureBox_ChooseFaceImage.Tag.ToString());
                using (var content = new ByteArrayContent(byteData))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                    response = await client.PostAsync(uri, content);
                }
            }
            else if(radioButton_NetImage.Checked)
            {
                string body = "{\"url\":\"" + textBox_NetImageUrl.Text + "\"}";
                byteData = Encoding.UTF8.GetBytes(body);
                using (var content = new ByteArrayContent(byteData))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    response = await client.PostAsync(uri, content);
                }
            }
            json = await response.Content.ReadAsStringAsync();
            textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
        }

        private void button_DeleteaPerson_Click(object sender, EventArgs e)
        {
            DeleteaPersonAsync();
        }

        async void DeleteaPersonAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox_DeleteaPersonPersonGroupId.Text + "/persons/"+ textBox_DeleteaPersonPersonId.Text + "?" + queryString;
            var response = await client.DeleteAsync(uri);
            textBox_Output.Text = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                textBox_Output.Text = "Delete Person " + textBox_DeleteaPersonPersonId.Text + " in PersonGroup " + textBox_DeleteaPersonPersonGroupId.Text + " Successfully";
            else
                textBox_Output.Text = "Delete Person " + textBox_DeleteaPersonPersonId.Text + " in PersonGroup " + textBox_DeleteaPersonPersonGroupId.Text + " Failed";
        }

        private void button_DeleteaPersonFace_Click(object sender, EventArgs e)
        {
            DeleteaPersonFaceAsync();
        }

        async void DeleteaPersonFaceAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox_DeleteaPersonFacePersongroupId.Text + "/persons/" + textBox_DeleteaPersonFacePersonId.Text + "/persistedFaces/" + textBox_DeleteaPersonFacePersistFaceId.Text + "?" + queryString;
            var response = await client.DeleteAsync(uri);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                textBox_Output.Text = "Delete Person Face " + textBox_DeleteaPersonFacePersistFaceId.Text + " Successfully";
            else
                textBox_Output.Text = "Delete Person Face " + textBox_DeleteaPersonFacePersistFaceId.Text + " Failed";
        }

        private void button_GetaPerson_Click(object sender, EventArgs e)
        {
            GetaPersonAsync();
        }

        async void GetaPersonAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox_GetaPersonPersonGroupId.Text + "/persons/" + textBox_GetaPersonPersonId.Text + "?" + queryString;
            var response = await client.GetAsync(uri);
            string json = await response.Content.ReadAsStringAsync();
            textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
        }

        private void button_GetaPersonFace_Click(object sender, EventArgs e)
        {
            GetaPersonFaceAsync();
        }

        async void GetaPersonFaceAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox_GetaPersonFacePersonGroupid.Text + "/persons/" + textBox_GetaPersonFacePersonid.Text + "/persistedFaces/" + textBox_GetaPersonFacePersistFaceid.Text + "?" + queryString;
            var response = await client.GetAsync(uri);
            string json = await response.Content.ReadAsStringAsync();
            textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
        }

        private void button_ListPersonsinaPersonGroup_Click(object sender, EventArgs e)
        {
            ListPersonsinaPersonGroupAsync();
        }

        async void ListPersonsinaPersonGroupAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/persongroups/" + textBox_ListPersonsinaPersonGroupPersonGroupId.Text + "/persons?" + queryString;
            var response = await client.GetAsync(uri);
            string json = await response.Content.ReadAsStringAsync();
            textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
        }
        #endregion

        #region Face List
        private void button_RandomaFaceListId_Click(object sender, EventArgs e)
        {
            textBox__CreateaFaceListId.Text = Guid.NewGuid().ToString();
        }

        private void button_CreateaFaceList_Click(object sender, EventArgs e)
        {
            CreateaFaceListAsync();
        }

        async void CreateaFaceListAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/facelists/" + textBox__CreateaFaceListId.Text + "?" + queryString;

            HttpResponseMessage response;

            // Request body
            PersonGroup personGroup1 = new PersonGroup
            {
                name = textBox__CreateaFaceListName.Text,
                userData = textBox__CreateaFaceListUserData.Text
            };
            string json = JsonConvert.SerializeObject(personGroup1, Formatting.Indented);
            byte[] byteData = Encoding.UTF8.GetBytes(json);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PutAsync(uri, content);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    textBox_Output.Text = "Create Face List " + textBox__CreateaFaceListId.Text + " Successfully";
                else
                    textBox_Output.Text = "Create Face List " + textBox__CreateaFaceListId.Text + " Failed\r\n" + response.StatusCode.ToString();
            }
        }

        private void button_DeleteaFaceList_Click(object sender, EventArgs e)
        {
            DeleteaFaceListAsync();
        }

        async void DeleteaFaceListAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/facelists/" + textBox_DeleteaFaceListId.Text + "?" + queryString;
            var response = await client.DeleteAsync(uri);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                textBox_Output.Text = "Delete Face List " + textBox_DeleteaFaceListId.Text + " Successfully";
            else
                textBox_Output.Text = "Delete Face List " + textBox_DeleteaFaceListId.Text + " Failed\r\n" + response.StatusCode.ToString();
        }

        private void radioButton_LocalImage1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_LocalImage1.Checked)
                textBox_NetImageUrl1.Enabled = false;
            else
                textBox_NetImageUrl1.Enabled = true;
        }

        private void radioButton_NetImage1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_NetImage1.Checked)
                button_ChooseAPersonFace1.Enabled = false;
            else
                button_ChooseAPersonFace1.Enabled = true;
        }

        private void button_ChooseAPersonFace1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "所有文件(*.*)|*.*|JPG文件(*.jpg)|*.jpg|JPEG文件(*.jpeg)|*.jpeg|PNG文件(*.png)|*.png|BMP文件(*.bmp)|*.bmp|GIF文件(*.gif)|*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_ChooseAPersonFace1.Image = Image.FromFile(opf.FileName);
                pictureBox_ChooseAPersonFace1.Tag = opf.FileName;
            }
        }

        private void button_AddFacetoFaceList_Click(object sender, EventArgs e)
        {
            AddFacetoFaceListAsync();
        }

        async void AddFacetoFaceListAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            // Request parameters
            queryString["userData"] = "";
            queryString["targetFace"] = "";
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/facelists/" + textBox_AddFacetoFaceList.Text + "/persistedFaces?" + queryString;

            HttpResponseMessage response = null;
            // Request body
            byte[] byteData;
            string json = "";
            if (radioButton_LocalImage1.Checked)
            {
                byteData = ImageHelper.SetImageToByteArray(pictureBox_ChooseAPersonFace1.Tag.ToString());
                using (var content = new ByteArrayContent(byteData))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                    response = await client.PostAsync(uri, content);
                }
            }
            else if (radioButton_NetImage1.Checked)
            {
                string body = "{\"url\":\"" + textBox_NetImageUrl1.Text + "\"}";
                byteData = Encoding.UTF8.GetBytes(body);
                using (var content = new ByteArrayContent(byteData))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    response = await client.PostAsync(uri, content);
                }
            }
            json = await response.Content.ReadAsStringAsync();
            textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);

        }

        private void button_DeleteaFacefromaFaceList_Click(object sender, EventArgs e)
        {
            DeleteaFacefromaFaceListAsync();
        }

        async void DeleteaFacefromaFaceListAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/facelists/" + textBox_DeleteaFacefromaFaceListId.Text + "/persistedFaces/" + textBox_DeleteaFacefromaFaceListPersistedFaceId.Text + "?" + queryString;
            var response = await client.DeleteAsync(uri);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                textBox_Output.Text = "Delete Persisted FaceId " + textBox_DeleteaFacefromaFaceListPersistedFaceId.Text + " From Face List " + textBox_DeleteaFacefromaFaceListId.Text + " Successfully";
            else
                textBox_Output.Text = "Delete Persisted FaceId " + textBox_DeleteaFacefromaFaceListPersistedFaceId.Text + " From Face List " + textBox_DeleteaFacefromaFaceListId.Text + " Failed";
        }

        private void button_GetaFaceList_Click(object sender, EventArgs e)
        {
            GetaFaceListAsync();
        }

        async void GetaFaceListAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/facelists/" + textBox_GetaFaceListId.Text + "?" + queryString;
            var response = await client.GetAsync(uri);
            string json = await response.Content.ReadAsStringAsync();
            textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
        }

        private void button_ListFaceLists_Click(object sender, EventArgs e)
        {
            ListFaceListsAsync();
        }

        async void ListFaceListsAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/facelists?" + queryString;
            var response = await client.GetAsync(uri);
            string json = await response.Content.ReadAsStringAsync();
            textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
        }
        #endregion

        #region Face
        private async void button_Detect_Click(object sender, EventArgs e)
        {
            if(checkBox_LocalImage.Checked)
            {
                Task<string> beginTask = DetectAsync(true, textBox_DetectImageLocation.Text);
                str_Detect_Result = await beginTask;
                textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(str_Detect_Result);
            }
            else
            {
                Task<string> beginTask = DetectAsync(false, textBox_DetectImageLocation.Text);
                str_Detect_Result = await beginTask;
                textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(str_Detect_Result);
            }

            DrawRectangle();
        }

        private void button_ChooseDetectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "所有文件(*.*)|*.*|JPG文件(*.jpg)|*.jpg|JPEG文件(*.jpeg)|*.jpeg|PNG文件(*.png)|*.png|BMP文件(*.bmp)|*.bmp|GIF文件(*.gif)|*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                textBox_DetectImageLocation.Text = opf.FileName;
                pictureBox_DetectedImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void checkBox_LocalImage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_LocalImage.Checked)
                button_ChooseDetectImage.Enabled = true;
            else
                button_ChooseDetectImage.Enabled = false;
        }

        private async Task<string> DetectAsync(bool b_IsLocalImage, string str_image_location)
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
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/detect?" + queryString;

            HttpResponseMessage response;

            // Request body
            byte[] byteData;
            if(checkBox_LocalImage.Checked)
                byteData = ImageHelper.SetImageToByteArray(str_image_location);
            else
            {
                string body = "{\"url\":\"" + textBox_DetectImageLocation.Text + "\"}";
                byteData = Encoding.UTF8.GetBytes(body);
            }

            using (var content = new ByteArrayContent(byteData))
            {
                if(checkBox_LocalImage.Checked)
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                else
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                response = await client.PostAsync(uri, content);
                return await response.Content.ReadAsStringAsync();
            }
        }

        //根据返回的Jsons数据，画出人脸矩形
        private void DrawRectangle()
        {
            FaceClass[] faces = JsonConvert.DeserializeObject<FaceClass[]>(str_Detect_Result);
            textBox_Output.Text += "\r\n\r\n" + faces.Length + " face(s) detected.";
            if (faces.Length > 0)
            {
                Image image = Image.FromFile(textBox_DetectImageLocation.Text);
                Bitmap bmp = (Bitmap)image;
                double dScalre = 1.0 * pictureBox_DetectedImage.Width / image.Width;

                for (int i = 0; i < faces.Length; i++)
                {
                    FaceClass face = faces[i];
                    Rectangle rect = new Rectangle(face.faceRectangle.left, face.faceRectangle.top, face.faceRectangle.width, face.faceRectangle.height);
                    Bitmap bmp1 = DrawRectangleInPicture(bmp, rect);
                    bmp = bmp1;
                }
                pictureBox_DetectedImage.Image = bmp;
            }
            else
                textBox_Output.Text = "No face detected";
        }

        public Bitmap DrawRectangleInPicture(Bitmap bmp, Rectangle rect)
        {
            if (bmp == null) return null;
            Graphics g = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Fuchsia, 6);
            g.DrawRectangle(pen, rect);
            g.Dispose();
            return bmp;
        }

        private void button_FindSimilar_Click(object sender, EventArgs e)
        {
            FindSimilarAsync();
        }

        async void FindSimilarAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/findsimilars?" + queryString;

            HttpResponseMessage response;

            // Request body
            FindSimilar findSimilar1 = new FindSimilar
            {
                faceId = textBox_FindSimilarFaceId.Text,
                faceListId = textBox_FindSimilarFaceListId.Text,
                maxNumOfCandidatesReturned = Convert.ToInt32(textBox_FindSimilarmaxNumOfCandidatesReturned.Text),
                mode = textBox_FindSimilarMode.Text
            };
            string json = JsonConvert.SerializeObject(findSimilar1, Formatting.Indented);
            byte[] byteData = Encoding.UTF8.GetBytes(json);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
                json = await response.Content.ReadAsStringAsync();
                textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
            }

        }

        private void button_Group_Click(object sender, EventArgs e)
        {
            GroupAsync();
        }

        async void GroupAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/group?" + queryString;

            HttpResponseMessage response;

            // Request body
            string body = "{\"faceIds\": [";
            //for (int i = 0; i < textBox_FaceIds.Lines.Length; i++)
            //{
            //    body += "\"" + textBox_FaceIds.Lines[i] + "\",";
            //}
            //body = body.Substring(0, body.Length - 1);
            //body += "]}";

            FaceIds fis = new FaceIds
            {
                faceIds = textBox_FaceIds.Lines
            };
            body = JsonConvert.SerializeObject(fis, Formatting.Indented);
            byte[] byteData = Encoding.UTF8.GetBytes(body);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
                string json = await response.Content.ReadAsStringAsync();
                textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
            }

        }

        private void button_Identify_Click(object sender, EventArgs e)
        {
            IdentifyAsync();
        }

        private void trackBar_confidenceThreshold_Scroll(object sender, EventArgs e)
        {
            label_confidenceThreshold.Text = (trackBar_confidenceThreshold.Value / 100.0).ToString();
        }

        async void IdentifyAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);

            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/identify?" + queryString;

            HttpResponseMessage response;

            // Request body
            if (textBox_faceidss.Lines.Length == 0)
                return;
            List<string> facesIds = new List<string>();
            for (int i = 0; i < textBox_faceidss.Lines.Length; i++)
            {
                facesIds.Add(textBox_faceidss.Lines[i]);
            }
            IdentifyJson identifyJson = new IdentifyJson
            {
                personGroupId = textBox_IdentifyPersonGroupId.Text,
                faceIds = facesIds.ToArray(),
                maxNumOfCandidatesReturned = Convert.ToInt32(textBox_maxNumOfCandidatesReturned.Text),
                confidenceThreshold = trackBar_confidenceThreshold.Value / 100.0
            };
            string json = JsonConvert.SerializeObject(identifyJson, Formatting.Indented);
            byte[] byteData = Encoding.UTF8.GetBytes(json);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);

                json = await response.Content.ReadAsStringAsync();
                textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(json);
            }
        }

        private void button_Verify_Click(object sender, EventArgs e)
        {
            if (textBox_VerifyFaceId1.Text == "" || textBox_VerifyFaceId2.Text == "")
                return;
            VerifyAsync();
        }

        private async void button_face1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "所有文件(*.*)|*.*|JPG文件(*.jpg)|*.jpg|JPEG文件(*.jpeg)|*.jpeg|PNG文件(*.png)|*.png|BMP文件(*.bmp)|*.bmp|GIF文件(*.gif)|*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_face1.Image = Image.FromFile(opf.FileName);
                
                Task<string> beginTask = DetectAsync(true, opf.FileName);
                str_Detect_Result = await beginTask;
                FaceClass[] faces = JsonConvert.DeserializeObject<FaceClass[]>(str_Detect_Result);
                if (faces.Length == 0)
                    return;
                textBox_VerifyFaceId1.Text = faces[0].faceId;
            }
        }

        private async void button_face2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "所有文件(*.*)|*.*|JPG文件(*.jpg)|*.jpg|JPEG文件(*.jpeg)|*.jpeg|PNG文件(*.png)|*.png|BMP文件(*.bmp)|*.bmp|GIF文件(*.gif)|*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_face2.Image = Image.FromFile(opf.FileName);

                Task<string> beginTask = DetectAsync(true, opf.FileName);
                str_Detect_Result = await beginTask;
                FaceClass[] faces = JsonConvert.DeserializeObject<FaceClass[]>(str_Detect_Result);
                if (faces.Length == 0)
                    return;
                textBox_VerifyFaceId2.Text = faces[0].faceId;
            }
        }

        async void VerifyAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", GeneralConstants.OxfordAPIKey);
            var uri = "https://westus.api.cognitive.microsoft.com/face/v1.0/verify?" + queryString;
            HttpResponseMessage response;

            // Request body
            string body = "";
            VeryfyFaceId vfi = new VeryfyFaceId
            {
                faceId1 = textBox_VerifyFaceId1.Text,
                faceId2 = textBox_VerifyFaceId2.Text
            };
            body = JsonConvert.SerializeObject(vfi, Formatting.Indented);
            byte[] byteData = Encoding.UTF8.GetBytes(body);
            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
                body = await response.Content.ReadAsStringAsync();
                textBox_Output.Text = JsonHelper.ConvertJsontoReadableString(body);
            }

        }
        #endregion

    }
}
