namespace PGS
{
    class Data
    {
        public string[] data;

        public Data()
        {
            data = new string[4];
            data[0] = "abc";
            data[1] = "def";
            data[2] = "ijk";
            data[3] = "xyz";
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
