﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeveloperForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Training_RecordsDataSet = New Fire_Dpt_Interface.Training_RecordsDataSet()
        Me.Emp_Info_AllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Emp_Info_AllTableAdapter = New Fire_Dpt_Interface.Training_RecordsDataSetTableAdapters.Emp_Info_AllTableAdapter()
        Me.TableAdapterManager = New Fire_Dpt_Interface.Training_RecordsDataSetTableAdapters.TableAdapterManager()
        Me.Emp_Info_Button = New System.Windows.Forms.Button()
        Me.LogOut_Button = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Class_Information_Button = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.Training_RecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Emp_Info_AllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Training_RecordsDataSet
        '
        Me.Training_RecordsDataSet.DataSetName = "Training_RecordsDataSet"
        Me.Training_RecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Emp_Info_AllBindingSource
        '
        Me.Emp_Info_AllBindingSource.DataMember = "Emp Info All"
        Me.Emp_Info_AllBindingSource.DataSource = Me.Training_RecordsDataSet
        '
        'Emp_Info_AllTableAdapter
        '
        Me.Emp_Info_AllTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ARFF_Subject_AreaTableAdapter = Nothing
        Me.TableAdapterManager.Assignment_PayTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CertificatesTableAdapter = Nothing
        Me.TableAdapterManager.Certification_Name_ListTableAdapter = Nothing
        Me.TableAdapterManager.Class_Attendance_InformationTableAdapter = Nothing
        Me.TableAdapterManager.Class_InformationTableAdapter = Nothing
        Me.TableAdapterManager.CollegeTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Employee_InformationTableAdapter = Nothing
        Me.TableAdapterManager.EMS_Certification_TypeTableAdapter = Nothing
        Me.TableAdapterManager.EMS_CertificationsTableAdapter = Nothing
        Me.TableAdapterManager.EMS_Content_AreaTableAdapter = Nothing
        Me.TableAdapterManager.Fire_and_EMS_OrganizationsTableAdapter = Nothing
        Me.TableAdapterManager.Fire_CertificationsTableAdapter = Nothing
        Me.TableAdapterManager.HM_Content_AreaTableAdapter = Nothing
        Me.TableAdapterManager.Non_FD_AttendanceTableAdapter = Nothing
        Me.TableAdapterManager.Other_CertificationsTableAdapter = Nothing
        Me.TableAdapterManager.Paul_File_ExportErrorsTableAdapter = Nothing
        Me.TableAdapterManager.TCFP_Subject_AreaTableAdapter = Nothing
        Me.TableAdapterManager.TCLEOSE_Subject_AreaTableAdapter = Nothing
        Me.TableAdapterManager.Training_AgenciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Fire_Dpt_Interface.Training_RecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Emp_Info_Button
        '
        Me.Emp_Info_Button.Location = New System.Drawing.Point(128, 68)
        Me.Emp_Info_Button.Name = "Emp_Info_Button"
        Me.Emp_Info_Button.Size = New System.Drawing.Size(103, 46)
        Me.Emp_Info_Button.TabIndex = 0
        Me.Emp_Info_Button.Text = "Employee Information"
        Me.Emp_Info_Button.UseVisualStyleBackColor = True
        '
        'LogOut_Button
        '
        Me.LogOut_Button.Location = New System.Drawing.Point(372, 196)
        Me.LogOut_Button.Name = "LogOut_Button"
        Me.LogOut_Button.Size = New System.Drawing.Size(103, 46)
        Me.LogOut_Button.TabIndex = 1
        Me.LogOut_Button.Text = "Log Out"
        Me.LogOut_Button.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(372, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 46)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Certification Lists"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(372, 68)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 46)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "EMS Certification Expiration"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Welcome: Username Here"
        '
        'Class_Information_Button
        '
        Me.Class_Information_Button.Location = New System.Drawing.Point(128, 132)
        Me.Class_Information_Button.Name = "Class_Information_Button"
        Me.Class_Information_Button.Size = New System.Drawing.Size(103, 46)
        Me.Class_Information_Button.TabIndex = 9
        Me.Class_Information_Button.Text = "Class Information"
        Me.Class_Information_Button.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(128, 196)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 46)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "CE Reports"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(128, 261)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(103, 46)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Employee Information"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DeveloperForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 339)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Class_Information_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LogOut_Button)
        Me.Controls.Add(Me.Emp_Info_Button)
        Me.Name = "DeveloperForm"
        Me.Text = "Main Menu"
        CType(Me.Training_RecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Emp_Info_AllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Training_RecordsDataSet As Fire_Dpt_Interface.Training_RecordsDataSet
    Friend WithEvents Emp_Info_AllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Emp_Info_AllTableAdapter As Fire_Dpt_Interface.Training_RecordsDataSetTableAdapters.Emp_Info_AllTableAdapter
    Friend WithEvents TableAdapterManager As Fire_Dpt_Interface.Training_RecordsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Emp_Info_Button As System.Windows.Forms.Button
    Friend WithEvents LogOut_Button As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Class_Information_Button As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
