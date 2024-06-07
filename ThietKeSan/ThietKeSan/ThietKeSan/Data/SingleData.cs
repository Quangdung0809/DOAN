namespace ThietKeSan
{
    internal class SingleData
    {
        public class Singleton
        {
            public static Singleton Instance
            { // Thể hiện tĩnh của Singleton   Remove featured image
                get;
                set;
            }

            private RevitData revitData;
            private FormData formData;

            public RevitData RevitData
            {
                get
                {
                    if (revitData == null) revitData = new RevitData();
                    return revitData;
                }
            }

            public FormData FormData
            {
                get
                {
                    if (formData == null) formData = new FormData();
                    return formData;
                }
            }

            // thuộc tính thành viên khác …
        }
    }
}