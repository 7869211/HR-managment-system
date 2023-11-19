 public void saveEmployee()
 {
     if (!string.IsNullOrEmpty(empId.Text) && !string.IsNullOrEmpty(empName.Text) && !string.IsNullOrEmpty(empCnic.Text) && !string.IsNullOrEmpty(empAddress.Text)
         && !string.IsNullOrEmpty(empContact.Text) && !string.IsNullOrEmpty(empEmail.Text) && !string.IsNullOrEmpty(empDesignation.Text) && !string.IsNullOrEmpty(empSalary.Text))
     {
         string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

         using (SqlConnection connection = new SqlConnection(connectionString))
         {
             connection.Open();
             string query = "INSERT INTO Employee (Employee_ID, Name, CNIC, Address, Contact, Email, Designation, BasicSalary, Allowances, NetSalary) VALUES (@Employee_ID, @Name, @CNIC, @Address, @Contact, @Email, @Designation, @BasicSalary, @Allowances, @NetSalary)";
             using (SqlCommand command = new SqlCommand(query, connection))
             {

                 command.Parameters.AddWithValue("@Employee_ID", Convert.ToInt32(empId.Text));
                 command.Parameters.AddWithValue("@Name", empName.Text);
                 command.Parameters.AddWithValue("@CNIC", empCnic.Text);
                 command.Parameters.AddWithValue("@Address", empAddress.Text);
                 command.Parameters.AddWithValue("@Contact", empContact.Text);
                 command.Parameters.AddWithValue("@Email", empEmail.Text);
                 command.Parameters.AddWithValue("@Designation", empDesignation.Text);
                 command.Parameters.AddWithValue("@BasicSalary", Convert.ToDecimal(empSalary.Text));
                 command.Parameters.AddWithValue("@Allowances", Convert.ToDecimal(empSalary.Text) / 10);
                 command.Parameters.AddWithValue("@NetSalary", (Convert.ToDecimal(empSalary.Text) / 10) + Convert.ToDecimal(empSalary.Text));

                 command.ExecuteNonQuery();
             }

             MessageBox.Show("Employee Saved Successfully");
         }
     }
     else
     {
         MessageBox.Show("All fields must be non-empty");
     }
 }


















 public void LoadEmployees(DataGridView employeeGrid)
 {
     string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

     using (SqlConnection connection = new SqlConnection(connectionString))
     {
         connection.Open();
         string query = "SELECT * FROM Employee";

         using (SqlCommand command = new SqlCommand(query, connection))
         {
             using (SqlDataAdapter adapter = new SqlDataAdapter(command))
             {
                 DataTable dataTable = new DataTable();
                 adapter.Fill(dataTable);

                 employeeGrid.DataSource = dataTable;
             }
         }
     }
 }















 private void updateEmployee()
 {
     if (!string.IsNullOrEmpty(empNameUpdate.Text) && !string.IsNullOrEmpty(empCnicUpdate.Text)
         && !string.IsNullOrEmpty(empAddressUpdate.Text) && !string.IsNullOrEmpty(empContactUpdate.Text) && !string.IsNullOrEmpty(empEmailUpdate.Text)
         && !string.IsNullOrEmpty(empDesignationUpdate.Text) && !string.IsNullOrEmpty(empSalaryUpdate.Text))
     {
         string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

         using (SqlConnection connection = new SqlConnection(connectionString))
         {
             connection.Open();

             string query = "UPDATE Employee SET Name = @Name, CNIC = @CNIC, Address = @Address, Contact = @Contact, Email = @Email, Designation = @Designation, BasicSalary = @BasicSalary, Allowances = @Allowances, NetSalary = @NetSalary WHERE Employee_ID = @Employee_ID";

             using (SqlCommand command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@Employee_ID", Convert.ToInt32(empID.Text));
                 command.Parameters.AddWithValue("@Name", empNameUpdate.Text);
                 command.Parameters.AddWithValue("@CNIC", empCnicUpdate.Text);
                 command.Parameters.AddWithValue("@Address", empAddressUpdate.Text);
                 command.Parameters.AddWithValue("@Contact", empContactUpdate.Text);
                 command.Parameters.AddWithValue("@Email", empEmailUpdate.Text);
                 command.Parameters.AddWithValue("@Designation", empDesignationUpdate.Text);
                 command.Parameters.AddWithValue("@BasicSalary", Convert.ToDecimal(empSalaryUpdate.Text));

                 // Assuming Allowances and NetSalary are decimal values. If not, adjust the data type accordingly.
                 command.Parameters.AddWithValue("@Allowances", Convert.ToDecimal(empSalaryUpdate.Text) / 10);
                 command.Parameters.AddWithValue("@NetSalary", (Convert.ToDecimal(empSalaryUpdate.Text) / 10) + Convert.ToDecimal(empSalaryUpdate.Text));

                 command.ExecuteNonQuery();

                 MessageBox.Show("Employee details updated successfully.");
             }
         }
     }
     else
     {
         MessageBox.Show("All fields must be non-empty");
     }
 }




















 public void InsertLeave(int employeeId, string leaveType, DateTime startDate, DateTime endDate)
 {
     if (employeeId > 0 && !string.IsNullOrEmpty(leaveType) && startDate <= endDate)
     {
         string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

         using (SqlConnection connection = new SqlConnection(connectionString))
         {
             connection.Open();

             string query = "INSERT INTO [dbo].[Leave] (EmployeeId, LeaveReason, StartDate, EndDate) VALUES (@EmployeeId, @LeaveType, @StartDate, @EndDate)";

             using (SqlCommand command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@EmployeeId", employeeId);
                 command.Parameters.AddWithValue("@LeaveType", leaveType);
                 command.Parameters.AddWithValue("@StartDate", startDate);
                 command.Parameters.AddWithValue("@EndDate", endDate);

                 command.ExecuteNonQuery();
             }

             MessageBox.Show("Leave record saved successfully.");
         }
     }
     else
     {
         MessageBox.Show("Invalid input values. Please check employee ID, leave type, and dates.");
     }
 }

 public DataTable SelectAllLeaves()
 {
     DataTable leaveData = new DataTable();

     string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

     using (SqlConnection connection = new SqlConnection(connectionString))
     {
         connection.Open();

         string query = "SELECT * FROM [dbo].[Leave]";

         using (SqlCommand command = new SqlCommand(query, connection))
         {
             using (SqlDataAdapter adapter = new SqlDataAdapter(command))
             {
                 adapter.Fill(leaveData);
             }
         }
     }

     return leaveData;
 }














  public decimal GetBasicSalaryByEmployeeId(int employeeId)
  {
      decimal basicSalary = 0;

      string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
          connection.Open();

          string query = "SELECT BasicSalary FROM Employee WHERE Employee_ID = @Employee_ID";

          using (SqlCommand command = new SqlCommand(query, connection))
          {
              command.Parameters.AddWithValue("@Employee_ID", employeeId);

              object result = command.ExecuteScalar();

              if (result != null && result != DBNull.Value)
              {
                  basicSalary = Convert.ToDecimal(result);
              }
          }
      }

      return basicSalary;
  }

  public string GetNameByEmployeeId(int employeeId)
  {
      string employeeName = null;

      string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
          connection.Open();

          string query = "SELECT Name FROM Employee WHERE Employee_ID = @Employee_ID";

          using (SqlCommand command = new SqlCommand(query, connection))
          {
              command.Parameters.AddWithValue("@Employee_ID", employeeId);

              object result = command.ExecuteScalar();

              if (result != null && result != DBNull.Value)
              {
                  employeeName = result.ToString();
              }
          }
      }

      return employeeName;
  }

  public DataTable ConvertStringArrayToDataTable(string[] stringArray)
  {
      
      DataTable dataTable = new DataTable();
      dataTable.Columns.Add("Employee_ID", typeof(string));
      dataTable.Columns.Add("Name", typeof(string));
      dataTable.Columns.Add("BasicSalary", typeof(string));
      dataTable.Columns.Add("Allowances", typeof(string));
      dataTable.Columns.Add("TotalLeaves", typeof(string));
      dataTable.Columns.Add("Deductions", typeof(string));
      dataTable.Columns.Add("NetSalary", typeof(string));


      DataRow row = dataTable.NewRow();
      for (int i = 0; i < stringArray.Length; i++)
      {
          row[i] = stringArray[i];
      }
      dataTable.Rows.Add(row);

      return dataTable;
  }


  private void button1_Click(object sender, EventArgs e)
  {
      Search search = new Search();
      if (search.SearchEmployeeById(Convert.ToInt32(empIdSalary.Text)))
      {
          string name = GetNameByEmployeeId(Convert.ToInt32(empIdSalary.Text));
          int noOfLeaves = GetTotalLeaveDaysForOctober2023(Convert.ToInt32(empIdSalary.Text));
          int basicPay = Convert.ToInt32(GetBasicSalaryByEmployeeId(Convert.ToInt32(empIdSalary.Text)));
          int allowance = basicPay / 10;
          int deductions = (basicPay / 30) * noOfLeaves;
          int netPay = basicPay + allowance - deductions;

          string[] individualPay = { Convert.ToString(empIdSalary.Text) , name, Convert.ToString(basicPay), Convert.ToString(allowance), Convert.ToString(noOfLeaves), Convert.ToString(deductions), Convert.ToString(netPay) };
          DataTable dataTable = ConvertStringArrayToDataTable(individualPay);
          payGrid.DataSource = dataTable;


      }
      else
      {
          MessageBox.Show("No employee found with the given ID.");
      }
  }

  public int GetTotalLeaveDaysForOctober2023(int employeeId)
  {
      int totalLeaveDays = 0;

      string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
          connection.Open();

          string query = "SELECT DATEDIFF(DAY, StartDate, EndDate) + 1 AS LeaveDays " +
                         "FROM [dbo].[Leave] " +
                         "WHERE EmployeeId = @EmployeeId " +
                         "AND YEAR(StartDate) = 2023 " +
                         "AND MONTH(StartDate) = 10";

          using (SqlCommand command = new SqlCommand(query, connection))
          {
              command.Parameters.AddWithValue("@EmployeeId", employeeId);

              using (SqlDataReader reader = command.ExecuteReader())
              {
                  while (reader.Read())
                  {
                      totalLeaveDays += Convert.ToInt32(reader["LeaveDays"]);
                  }
              }
          }
      }

      return totalLeaveDays;
  }



















 public int[] GetAllEmployeeIds()
 {
     List<int> employeeIds = new List<int>();

     string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

     using (SqlConnection connection = new SqlConnection(connectionString))
     {
         connection.Open();

         string query = "SELECT Employee_ID FROM Employee";

         using (SqlCommand command = new SqlCommand(query, connection))
         {
             using (SqlDataReader reader = command.ExecuteReader())
             {
                 while (reader.Read())
                 {
                     int employeeId = reader.GetInt32(reader.GetOrdinal("Employee_ID"));
                     employeeIds.Add(employeeId);
                 }
             }
         }
     }

     return employeeIds.ToArray();
 }















 public bool SearchEmployeeById(int employeeId)
 {
     bool employeeExists = false;

     string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

     using (SqlConnection connection = new SqlConnection(connectionString))
     {
         connection.Open();

         
         int searchId = employeeId;

         string query = "SELECT 1 FROM Employee WHERE Employee_ID = @Employee_ID";

         using (SqlCommand command = new SqlCommand(query, connection))
         {
             command.Parameters.AddWithValue("@Employee_ID", searchId);

             object result = command.ExecuteScalar();

             if (result != null && result != DBNull.Value)
             {
                 
                 employeeExists = true;
             }
         }
     }

     return employeeExists;
 }











  public void removeEmployee()
  {
      Search search = new Search();
      if (search.SearchEmployeeById(Convert.ToInt32(removeId.Text)))
      {
          string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HR_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False";

          using (SqlConnection connection = new SqlConnection(connectionString))
          {
              connection.Open();

              string query = $"Delete from Employee where Employee_ID = '{Convert.ToInt32(removeId.Text)}'";

              using (SqlCommand command = new SqlCommand(query, connection))
              {
                  command.ExecuteNonQuery();
              }
             
          }
          MessageBox.Show("Employee removed successfully.");
          ViewEmployees employees = new ViewEmployees();
          employees.LoadEmployees(removeGrid);

      }
      else
      {
          MessageBox.Show("No employee found with the given ID.");
      }
  }
        













