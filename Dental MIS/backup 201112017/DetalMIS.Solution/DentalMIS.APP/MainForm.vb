Imports System.Windows.Forms

Public Class MainForm
    Public isLogin As Boolean = False
    Private Sub ClearControls()
        For Each control As Control In PanelMain.Controls
            PanelMain.Controls.Remove(control)
        Next
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dim confirm = MessageBox.Show("Exit System?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Environment.Exit(0)
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        If PanelSideMenu.Width = 55 Then
            PanelSideMenu.Visible = False
            PanelSideMenu.Width = 182
            LabelMenu.Visible = True
            PanelAnimator.ShowSync(PanelSideMenu)
        Else
            PanelSideMenu.Visible = False
            PanelSideMenu.Width = 55
            LabelMenu.Visible = False
            PanelAnimator.ShowSync(PanelSideMenu)
        End If
    End Sub

    Private Sub ButtonPatient_Click(sender As Object, e As EventArgs) Handles ButtonPatient.Click
        ClearControls()
        Dim patientControl As New PatientControl
        patientControl.Dock = DockStyle.Fill
        PanelMain.Controls.Add(patientControl)
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        ClearControls()
        Dim dashboardControl As New DashboardControl
        dashboardControl.Dock = DockStyle.Fill
        PanelMain.Controls.Add(dashboardControl)
    End Sub

    Private Sub ButtonConfiguration_Click(sender As Object, e As EventArgs) Handles ButtonConfiguration.Click
        ClearControls()
        Dim configurationControl As New ConfigurationControl
        configurationControl.Dock = DockStyle.Fill
        PanelMain.Controls.Add(configurationControl)
    End Sub

    Private Sub buttonLogout_Click(sender As Object, e As EventArgs) Handles buttonLogout.Click
        Dim confirm = MessageBox.Show("Logout Account?", "Olaes Dental Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            isLogin = False
            PanelSideMenu.Visible = False
            PanelMain.Visible = False
            LoginForm.MdiParent = Me
            LoginForm.Show()
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

        If (Not isLogin) Then
            PanelSideMenu.Visible = False
            PanelMain.Visible = False
            LoginForm.MdiParent = Me
            LoginForm.Show()
        End If
    End Sub
End Class
