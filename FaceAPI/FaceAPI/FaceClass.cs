namespace FaceAPI
{
    class FaceClass
    {
        //public class Face
        //{
            public string faceId { get; set; }
            public FaceRectangle faceRectangle { get; set; }
            public FaceAttributes faceAttributes { get; set; }
        //}

        public class FaceRectangle
        {
            public int width { get; set; }
            public int height { get; set; }
            public int left { get; set; }
            public int top { get; set; }
        }
        
        public class FaceAttributes
        {
            public double age { get; set; }
            public string gender { get; set; }
            public double smile { get; set; }
            public facialHair facialhair { get; set; }
            public string glasses { get; set; }
            public headPose headpose { get; set; }
        }

        public class facialHair
        {
            public double mustache { get; set; }
            public double beard { get; set; }
            public double sideburns { get; set; }
        }

        public class headPose
        {
            public double roll { get; set; }
            public double yaw { get; set; }
            public double pitch { get; set; }
        }
    }
}
