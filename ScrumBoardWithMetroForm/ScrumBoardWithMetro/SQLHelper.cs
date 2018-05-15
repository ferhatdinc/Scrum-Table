using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows;
using ScrumBoardWithMetro.Forms;

namespace ScrumBoardWithMetro
{
    public class SQLHelper
    {
        private static string defaultConnectionString;
        public static void SQLStart(string _SqlConnectionString) => defaultConnectionString = _SqlConnectionString;
        public static bool InsertStory(Story S) //Eklemek İstediğin Parametleri Direk Yolla txt'den Gelen Tc Convert Et Öyle Yolla
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("INSERT INTO Story(Story_Description,StoryLocationX,StoryLocationY,Story_Color,Story_Name,Story_AddDate,Story_Author) VALUES ('" + S.Story_Description + "','" + S.StoryLocationX + "','" + S.StoryLocationY + "','" + S.Story_Color + "','" + S.Story_Name + "','" + S.Story_AddDate + "','" + S.Story_Author + "')", Connect);
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw;
                }
                Connect.Close();
                return true;
            }
            else
                return false;
        }

        public static bool InsertTask(Task T) //Eklemek İstediğin Parametleri Direk Yolla txt'den Gelen Tc Convert Et Öyle Yolla
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("INSERT INTO Task(Task_DeadLine,TaskLocationX,TaskLocationY,Task_Author,Task_Status,Task_Description,Story_ID,Task_Color,Task_Header) VALUES('" + T.Task_DeadLine + "','" + T.TaskLocationX + "','" + T.TaskLocationY + "','" + T.Task_Author + "','" + T.Task_Status + "','" + T.Task_Description + "','" + T.Story_ID + "','" + T.Task_BackColor + "','" + T.Task_Header + "')", Connect);
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    return false;
                }
                Connect.Close();
                return true;
            }
            else
                return false;
        }

        public static List<PictureBoxInfo> Select() //Parametre Almaz Eğer Return Value Null!=İse İşlem Başarılı Denebilir.
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            List<PictureBoxInfo> PassValue = new List<PictureBoxInfo>();
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Story", Connect);

                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PictureBoxInfo AddPB = new PictureBoxInfo();
                    AddPB.PB_BackColor = (reader["Story_Color"].ToString());
                    AddPB.PB_Size = new Size(140, 140);
                    AddPB.PB_Location = new Point((int)reader["StoryLocationX"], (int)reader["StoryLocationY"]);
                    AddPB.Story_ID = (int)reader["Story_ID"];
                    AddPB.Story_Task_Count = (int)reader["Story_Task_Count"];
                    AddPB.Story_Description = (string)reader["Story_Description"];
                    AddPB.Story_Name = (string)reader["Story_Name"];
                    AddPB.Story_AddDate = (string)reader["Story_AddDate"];
                    AddPB.Story_Author = (string)reader["Story_Author"];
                    PassValue.Add(AddPB);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }



        public static List<PictureBoxInfo> SelectTask() //Parametre Almaz Eğer Return Value Null!=İse İşlem Başarılı Denebilir.
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            List<PictureBoxInfo> PassValue = new List<PictureBoxInfo>();
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Task", Connect);

                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PictureBoxInfo AddPB = new PictureBoxInfo();
                    AddPB.PB_BackColor = (reader["Task_Color"]).ToString();
                    AddPB.PB_Size = new Size(140, 28);
                    AddPB.PB_Location = new Point((int)reader["TaskLocationX"], (int)reader["TaskLocationY"]);
                    AddPB.Story_ID = (int)reader["Story_ID"];
                    AddPB.Task_ID = (int)reader["Task_ID"];
                    AddPB.Task_Status = (int)reader["Task_Status"];
                    AddPB.Task_Author = (string)reader["Task_Author"];
                    AddPB.Task_DeadLine = (string)reader["Task_DeadLine"];
                    AddPB.Task_Header = (string)reader["Task_Header"];
                    PassValue.Add(AddPB);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }
        public static bool UpdateTask(int _Task_ID, int Status_Value)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("UPDATE Task SET Task_Status='" + Status_Value + "'WHERE Task_ID=@Task_ID", Connect);
                Cmd.Parameters.AddWithValue("@Task_ID", _Task_ID);
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return true;
            }
            else
                return false;
        }


        public static Point GetLastRow()
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Point PassValue = Point.Empty;
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT TOP 1 * FROM Story ORDER BY Story_ID DESC", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PassValue = new Point((int)reader[2], (int)reader[3] + 140);

                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return Point.Empty;
        }

        public static Point GetLastRowTask(int Story_No)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Point PassValue = Point.Empty;
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT TOP 1 * FROM Task WHERE Story_ID='" + Story_No + "' ORDER BY Task_ID DESC", Connect); //From Task Olabilir
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PassValue = new Point((int)reader[2], (int)reader[3] + 28);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return Point.Empty;
        }
        public static string GetTaskInfo(int Task_ID,int Story_ID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                string Task_Info = " ";
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT *FROM Story LEFT JOIN Task ON Task.Story_ID=Story.Story_ID", Connect); //From Task Olabilir

                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    if ((int)reader["Task_ID"] == Task_ID || (int)reader["Story_ID"]==Story_ID)
                    {
                        Task_Info = " Story Adı : " + (string)reader["Story_Name"] + "/ Task Başlığı : " + (string)reader["Task_Header"] + "/ Story Tanımı : " + (string)reader["Story_Description"] + "/ Task Sahibi : " + reader["Task_Author"] + "/ Durum : /" + reader["Task_Status"] + "/ Task Tanımı : " + reader["Task_Description"] + "/ Bitirme Tarihi : " + reader["Task_DeadLine"] + "/ Story Sahibi : " + reader["Story_Author"] + "/ Story Eklenme Tarihi : " + reader["Story_AddDate"];
                        return Task_Info;
                    }
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
            }
            return null;

        }


        public static void UpdateTaskCount(int Story_ID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                int Task_Count = 0;
                SqlCommand Cmd = new SqlCommand("SELECT *FROM Story WHERE Story_ID='" + Story_ID + "'", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    if ((int)reader["Story_ID"] == Story_ID)
                    {
                        Task_Count = (int)reader["Story_Task_Count"];
                        Cmd = new SqlCommand("UPDATE Story SET Story_Task_Count='" + (Task_Count + 1) + "' WHERE Story_ID='" + Story_ID + "'", Connect);
                    }
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
            }
        }

        public static bool DeleteAllDB()
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("DELETE FROM Task", Connect);
                Cmd.ExecuteNonQuery();
                Cmd = new SqlCommand("DELETE FROM Story", Connect);
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return true;
            }
            else
                return false;
        }

        public static bool DeleteTask(int Task_ID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("DELETE FROM Kimlik WHERE Task_ID=@Task_ID", Connect);
                Cmd.Parameters.AddWithValue("@Task_ID",Task_ID);
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return true;
            }
            else
                return false;

        }



    }
}
