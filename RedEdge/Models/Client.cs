using GalaSoft.MvvmLight;

namespace RedEdge.Models
{
    public class Client : ObservableObject
    {
        public int ClientId { get; set; }

        private string _givenName;
        public string GivenName
        {
            get
            {
                return _givenName;
            }
            set
            {
                Set(() => GivenName, ref _givenName, value);

            }
        }
        private string _familyName;
        public string FamilyName
        {
            get
            {
                return _familyName;
            }
            set
            {
                Set(() => FamilyName, ref _familyName, value);
            }
        }
    }
}
