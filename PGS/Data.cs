namespace PGS
{
    class Data
    {
        public string[] data;

        public Data()
        {
            data = new string[4];
        }

        public string getData(int i)
        {
            return data[i];
        }

        public void setData(int i, string s)
        {
            data[i] = s;
        }
    }
}