namespace ETradeParallel.Infrastructure.Operations
{
    public static class CharacterOperation
    {
        static string[] characters =
        {
         "\"", "!","'","^","+","%","&","/","(",")","=","?","_","+",
         " ","@","€","¨","~",",",";",":",".","Ö","ö","Ü","ü",
         "ı","İ","ğ","Ğ","æ","ß","â","î","ş","Ş","Ç","ç","<",">","|",
        };

        public static string CharacterRegulatory(string name)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                name.Replace(characters[i], "");
            }
            return name;
        }
    }
}
