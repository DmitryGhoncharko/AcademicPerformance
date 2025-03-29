using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using AcademicPerformance.Classes.DataModels;

namespace AcademicPerformance.Classes.DataSqlGateways
{
    public partial class SqlDataAccess
    {
        #region JournalAccess

        public List<JournalModel> GetJournalListForUser()
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new SqlConnection(ConstSqlConfig.DefaultCnnVal()))
            {
                const string sqlQuery = @"SELECT [IdJournal], 
                    [LastNameStudent], [FirstNameStudent], [MiddleNameStudent], [Student].[Class],
                    [NameEvaluation], [NumberEvaluation],
                    [LastNameTeacher], [FirstNameTeacher], [MiddleNameTeacher],
                    [NameDiscipline],
                    [Journal].[IdStudent], [Journal].[IdTeacher],
                    [Journal].[IdDiscipline], [Journal].[IdEvaluation]
                    FROM [dbo].[Journal]
                    INNER JOIN [dbo].[Student] ON Student.IdStudent = Journal.IdStudent
                    INNER JOIN [dbo].[Teacher] ON Teacher.IdTeacher = Journal.IdTeacher
                    INNER JOIN [dbo].[Evaluation] ON Evaluation.IdEvaluation = Journal.IdEvaluation
                    INNER JOIN [dbo].[Discipline] ON Discipline.IdDiscipline = Journal.IdDiscipline
                    WHERE Student.IdUser = @IdUser OR Teacher.IdUser = @IdUser";

                using (var sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("IdUser", App.IdUser);
                    var dataAdapter = new SqlDataAdapter(sqlCommand);
                    dataAdapter.Fill(dataTable);
                }

                var journalList = (from DataRow dataRow in dataTable.Rows
                    select new JournalModel
                    {
                        IdJournal = Convert.ToInt32(dataRow["IdJournal"]),
                        LastNameStudent = dataRow["LastNameStudent"].ToString(),
                        FirstNameStudent = dataRow["FirstNameStudent"].ToString(),
                        MiddleNameStudent = dataRow["MiddleNameStudent"].ToString(),
                        ClassStudent = dataRow["Class"].ToString(),
                        NameEvaluation = dataRow["NameEvaluation"].ToString(),
                        NumberEvaluation = Convert.ToInt32(dataRow["NumberEvaluation"]),
                        LastNameTeacher = dataRow["LastNameTeacher"].ToString(),
                        FirstNameTeacher = dataRow["FirstNameTeacher"].ToString(),
                        MiddleNameTeacher = dataRow["MiddleNameTeacher"].ToString(),
                        NameDiscipline = dataRow["NameDiscipline"].ToString(),
                        IdStudent = Convert.ToInt32(dataRow["IdStudent"]),
                        IdTeacher = Convert.ToInt32(dataRow["IdTeacher"]),
                        IdDiscipline = Convert.ToInt32(dataRow["IdDiscipline"]),
                        IdEvaluation = Convert.ToInt32(dataRow["IdEvaluation"]),
                    }).ToList();

                return journalList;
            }
        }

        public List<JournalModel> GetJournalList()
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new SqlConnection(ConstSqlConfig.DefaultCnnVal()))
            {
                const string sqlQuery = @"SELECT [IdJournal], 
                    [LastNameStudent], [FirstNameStudent], [MiddleNameStudent], [Student].[Class],
                    [NameEvaluation], [NumberEvaluation],
                    [LastNameTeacher], [FirstNameTeacher], [MiddleNameTeacher],
                    [NameDiscipline],
                    [Journal].[IdStudent], [Journal].[IdTeacher],
                    [Journal].[IdDiscipline], [Journal].[IdEvaluation]
                    FROM [dbo].[Journal]
                    INNER JOIN [dbo].[Student] ON Student.IdStudent = Journal.IdStudent
                    INNER JOIN [dbo].[Teacher] ON Teacher.IdTeacher = Journal.IdTeacher
                    INNER JOIN [dbo].[Evaluation] ON Evaluation.IdEvaluation = Journal.IdEvaluation
                    INNER JOIN [dbo].[Discipline] ON Discipline.IdDiscipline = Journal.IdDiscipline";

                using (var sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    var dataAdapter = new SqlDataAdapter(sqlCommand);
                    dataAdapter.Fill(dataTable);
                }

                var journalList = (from DataRow dataRow in dataTable.Rows
                    select new JournalModel
                    {
                        IdJournal = Convert.ToInt32(dataRow["IdJournal"]),
                        LastNameStudent = dataRow["LastNameStudent"].ToString(),
                        FirstNameStudent = dataRow["FirstNameStudent"].ToString(),
                        MiddleNameStudent = dataRow["MiddleNameStudent"].ToString(),
                        ClassStudent = dataRow["Class"].ToString(),
                        NameEvaluation = dataRow["NameEvaluation"].ToString(),
                        NumberEvaluation = Convert.ToInt32(dataRow["NumberEvaluation"]),
                        LastNameTeacher = dataRow["LastNameTeacher"].ToString(),
                        FirstNameTeacher = dataRow["FirstNameTeacher"].ToString(),
                        MiddleNameTeacher = dataRow["MiddleNameTeacher"].ToString(),
                        NameDiscipline = dataRow["NameDiscipline"].ToString(),
                        IdStudent = Convert.ToInt32(dataRow["IdStudent"]),
                        IdTeacher = Convert.ToInt32(dataRow["IdTeacher"]),
                        IdDiscipline = Convert.ToInt32(dataRow["IdDiscipline"]),
                        IdEvaluation = Convert.ToInt32(dataRow["IdEvaluation"]),
                    }).ToList();

                return journalList;
            }
        }

        public JournalModel GetJournal(int idJournal)
        {
            var tempJournal = new JournalModel();
            using (var sqlConnection = new SqlConnection(ConstSqlConfig.DefaultCnnVal()))
            {
                try
                {
                    const string sqlQuery =
                        @"SELECT IdJournal, IdStudent, IdTeacher, IdDiscipline, IdEvaluation
                        FROM [dbo].[Journal]
                        WHERE [Journal].IdJournal = @IdJournal";
                    SqlDataReader reader;
                    using (var sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.Parameters.AddWithValue("IdJournal", idJournal);
                        reader = sqlCommand.ExecuteReader();
                    }

                    var items = new List<JournalModel>();
                    while (reader.Read())
                    {
                        var u = new JournalModel
                        {
                            IdJournal = (int) reader["IdEvaluation"],
                            IdStudent = (int) reader["IdStudent"],
                            IdTeacher = (int) reader["IdTeacher"],
                            IdDiscipline = (int) reader["IdDiscipline"],
                            IdEvaluation = (int) reader["IdEvaluation"]
                        };

                        items.Add(u);
                    }

                    if (items.Count > 0)
                        tempJournal = items[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }

            return tempJournal;
        }

        public bool InsertJournal(JournalModel journalModel)
        {
            var isInserted = false;
            using (var sqlConnection = new SqlConnection(ConstSqlConfig.DefaultCnnVal()))
            {
                try
                {
                    const string sqlQuery = 
                        @"INSERT INTO dbo.[Journal] 
                        (IdStudent, IdTeacher, IdDiscipline, IdEvaluation) 
                        VALUES (@IdStudent, @IdTeacher, @IdDiscipline, @IdEvaluation)";
                    int noOfRowsAffected;
                    using (var sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                    {
                        if (journalModel != null)
                        {
                            sqlCommand.Parameters.AddWithValue("IdStudent", journalModel.IdStudent);
                            sqlCommand.Parameters.AddWithValue("IdTeacher", journalModel.IdTeacher);
                            sqlCommand.Parameters.AddWithValue("IdDiscipline", journalModel.IdDiscipline);
                            sqlCommand.Parameters.AddWithValue("IdEvaluation", journalModel.IdEvaluation);
                        }

                        sqlConnection.Open();
                        noOfRowsAffected = sqlCommand.ExecuteNonQuery();
                    }

                    isInserted = noOfRowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }

            return isInserted;
        }

        public bool UpdateJournal(JournalModel journalModel)
        {
            var isUpdated = false;
            using (var sqlConnection = new SqlConnection(ConstSqlConfig.DefaultCnnVal()))
            {
                try
                {
                    const string sqlQuery = 
                        @"UPDATE dbo.[Journal] 
                        SET IdTeacher=@IdTeacher, IdStudent=@IdStudent, 
                        IdDiscipline=@IdDiscipline, IdEvaluation=@IdEvaluation
                        WHERE IdJournal=@IdJournal";
                    int noOfRowsAffected;
                    using (var sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                    {
                        if (journalModel != null)
                        {
                            sqlCommand.Parameters.AddWithValue("IdJournal", journalModel.IdJournal);
                            sqlCommand.Parameters.AddWithValue("IdTeacher", journalModel.IdTeacher);
                            sqlCommand.Parameters.AddWithValue("IdStudent", journalModel.IdStudent);
                            sqlCommand.Parameters.AddWithValue("IdDiscipline", journalModel.IdDiscipline);
                            sqlCommand.Parameters.AddWithValue("IdEvaluation", journalModel.IdEvaluation);
                        }

                        sqlConnection.Open();
                        noOfRowsAffected = sqlCommand.ExecuteNonQuery();
                    }

                    isUpdated = noOfRowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }

            return isUpdated;
        }

        public bool DeleteJournal(int idJournal)
        {
            var isDeleted = false;
            using (var sqlConnection = new SqlConnection(ConstSqlConfig.DefaultCnnVal()))
            {
                try
                {
                    const string sqlQuery = 
                        @"DELETE FROM dbo.[Journal] WHERE IdJournal=@IdJournal";
                    int noOfRowsAffected;
                    using (var sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("IdJournal", idJournal);
                        sqlConnection.Open();
                        noOfRowsAffected = sqlCommand.ExecuteNonQuery();
                    }

                    isDeleted = noOfRowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }

            return isDeleted;
        }

        #endregion
    }
}