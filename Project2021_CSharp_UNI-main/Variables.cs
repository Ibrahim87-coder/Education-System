using System;
using System.Drawing;
using System.Data;

namespace Start
{
    class Variables
    {
        public static Introduction intro;
        public static MatiereStart matiere;
      
        public static ScienceStart science;
        
        public static Page_entrée formLogin;
        public static Message m;

        public static Jeux Jeux;

        public static  cours_de_grammaire g = new cours_de_grammaire();
        
        public static string [] exSup { get; set; }
       
       public static int levelmt { get; set; }
       

       public static int levelfr { get; set; }
       
        public static Bitmap B { get; set; }
       
        
        public static int counter { get; set; }
        
        public static string MatiereNomPublic { get; set; }
       

        // Nom de l'utilisateur
      //  static string usernom;
        public static string UserNom { get; set; }
        
        public static bool ExisteMessage(string s)
        {
            DataSet ds = new DataSet(); int i = 0; bool o = false;
           ds.ReadXml("message.xml");
            DataTable dt = ds.Tables[0];
            while (i < dt.Rows.Count)
            {
                if ((s == dt.Rows[i][1].ToString()) && (dt.Rows[i][3].ToString() == "false")) o = true;
                i++;
            }
            return o;
        }
        static DataTable dt;
        static DataRow[] dr;
        static DataSet ds;
        public static DataRow[] XmlReader(string path)
        {
            ds = new DataSet();
            ds.ReadXml(path);
            dt = ds.Tables[0];
            dr = dt.Select("(([user] = '" + Variables.UserNom + "') AND ([pass] = '" +    Variables.UserPass  + "'))");
            return dr;
        }

        public static void XmlWriter(string path)
        {
            ds.WriteXml(path);

        }
        
        public static bool Type { get; set; }
        
        
        public static string UserPass { get; set; } 
        
        // form de francais
        public static bool Exit = true;

    }
}
