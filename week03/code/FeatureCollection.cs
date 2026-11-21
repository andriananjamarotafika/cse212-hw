public class FeatureCollection
{
    public string type { get; set; }


    public class Metadata
    {
        public double generated { get; set; }
        public string url { get; set; }
        public string title { get; set; }

        public int status { get; set; }
        public string api { get; set; }
        public int count { get; set; }


    }

    public class Features
    {
        public string type { get; set; }

    }

}



