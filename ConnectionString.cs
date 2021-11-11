namespace api
{
    public class ConnectionString
    {
        public string cs {get; set;}
        public ConnectionString()
        {
            string server = "en1ehf30yom7txe7.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "w3drkir639ig3zt5";
            string port = "3306";
            string userName = "v8p4qi8gbyzm08tt";
            string password = "brce88jbjl708mbl";

            cs = $@"server = {server};user={userName};database={database};port={port};password={password};";
        }
    }
}