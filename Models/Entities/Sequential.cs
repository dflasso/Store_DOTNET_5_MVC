namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class Sequential
    {
        public Sequential()
        {
        }

        public int SequentialId {get; set;}
        public string SequentialEstablishment {get; set;}
        public string SequentialNum {get; set;}
        public string SequentialDescription {get; set;}

        public Sequential(int sequentialId, string sequentialEstablishment, string sequentialNum, string sequentialDescription)
        {
            SequentialId = sequentialId;
            SequentialEstablishment = sequentialEstablishment;
            SequentialNum = sequentialNum;
            SequentialDescription = sequentialDescription;
        }
    }
}