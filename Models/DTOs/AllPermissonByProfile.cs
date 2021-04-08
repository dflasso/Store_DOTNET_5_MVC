namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class AllPermissonByProfile
    {
        public AllPermissonByProfile()
        {
        }

        public int Value {get; set;}
        public string Label { get; set;}
        public bool IsSelected {get; set;}

        public AllPermissonByProfile(int value, string label, bool isSelected)
        {
            Value = value;
            Label = label;
            IsSelected = isSelected;
        }
    }
}