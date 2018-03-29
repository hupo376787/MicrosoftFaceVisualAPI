namespace FaceAPI
{
    class PersonGroup
    {
        public string name { get; set; }
        public string userData { get; set; }
    }

    class PersonId
    {
        public string personId { get; set; }
    }

    class Person
    {
        public string name { get; set; }
        public string userData { get; set; }
    }

    class FaceIds
    {
        public string[] faceIds { get; set; }
    }

    public class VeryfyFaceId
    {
        public string faceId1 { get; set; }

        public string faceId2 { get; set; }
    }

    class IdentifyJson
    {
        public string personGroupId { get; set; }
        public string[] faceIds { get; set; }
        public int maxNumOfCandidatesReturned { get; set; }
        public double confidenceThreshold { get; set; }
    }

    class IdentifyResult
    {
        public string faceId { get; set; }
        public Candidates[] candidates { get; set; }
    }

    class Candidates
    {
        public string personId { get; set; }
        public double confidence { get; set; }
    }

    class Personss
    {
        public string personId { get; set; }
        //public PersistedFaceIds[] persistedFaceIds { get; set; }
        public string name { get; set; }
        public string userData { get; set; }
    }

    class PersistedFaceIds
    {
        public string persistedFaceIds { get; set; }
    }

    class FindSimilar
    {
        public string faceId { get; set; }
        public string faceListId { get; set; }
        public int maxNumOfCandidatesReturned { get; set; }
        public string mode { get; set; }
    }
}
