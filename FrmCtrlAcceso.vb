Imports System.Data.SqlClient

Public Class FrmCtrlAcceso
    Dim DataSetAcceso As Data.DataSet
    Dim AdaptadorAcceso As System.Data.SqlClient.SqlDataAdapter
    Dim DataSetUsuario As Data.DataSet
    Dim AdaptadorUsuario As System.Data.SqlClient.SqlDataAdapter
    Dim DataSetUsuarioPerfil As Data.DataSet
    Dim AdaptadorUsuarPerfil As System.Data.SqlClient.SqlDataAdapter
    Dim FilaUsuarioPerfil As Integer
    Dim FilaUsuario As Integer
    Dim DataSetUsuarioSucursal As Data.DataSet
    Dim AdaptadorUsuarSucursal As System.Data.SqlClient.SqlDataAdapter

    Sub CargarAcceso()
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        con.Open()

        StrSQL = "SELECT ID_PERFIL,SISTEMA,NOMBRE,STATUS FROM QAPD_CONTROL.DBO.MANPERFILES"
        Dim comandoSQL As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
        comandoSQL.CommandType = CommandType.Text

        AdaptadorAcceso = New System.Data.SqlClient.SqlDataAdapter(comandoSQL)
        DataSetAcceso = New Data.DataSet("DS_ACCESO")
        AdaptadorAcceso.Fill(DataSetAcceso, "DS_ACCESO")
        GRID_ACCESOS.DataSource = DataSetAcceso.Tables("DS_ACCESO")
        BS_ACCESOS.DataSource = DataSetAcceso.Tables("DS_ACCESO")

        GRID_ACCESOS.Columns(0).ReadOnly = True
        GRID_ACCESOS.Columns(0).DefaultCellStyle.BackColor = Color.LemonChiffon
        GRID_ACCESOS.Columns(0).Width = 20
        GRID_ACCESOS.Columns(2).Width = 250

        Dim comandoB As System.Data.SqlClient.SqlCommandBuilder = New System.Data.SqlClient.SqlCommandBuilder(AdaptadorAcceso)






        StrSQL = "SELECT Cod_Usuario,Desc_Usuario FROM MasterProfitProA.DBO.MpUsuario"
        Dim comandoSQLUsuarios As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
        comandoSQLUsuarios.CommandType = CommandType.Text
        AdaptadorUsuario = New System.Data.SqlClient.SqlDataAdapter(comandoSQLUsuarios)
        DataSetUsuario = New Data.DataSet("DS_USUARIO")

        AdaptadorUsuario.Fill(DataSetUsuario, "DS_USUARIO")
        GRID_USUARIOS.DataSource = DataSetUsuario.Tables("DS_USUARIO")
        BS_USUARIOS.DataSource = DataSetUsuario.Tables("DS_USUARIO")
        GRID_USUARIOS.Columns(0).ReadOnly = True
        GRID_USUARIOS.Columns(1).ReadOnly = True
        GRID_USUARIOS.Columns(0).DefaultCellStyle.BackColor = Color.LemonChiffon
        GRID_USUARIOS.Columns(1).DefaultCellStyle.BackColor = Color.LemonChiffon
        GRID_USUARIOS.Columns(0).Width = 150
        GRID_USUARIOS.Columns(1).Width = 250


        StrSQL = "SELECT A.usuario CodigoUsuario,C.Desc_Usuario NombreUsuario,B.nombre Perfil,CASE WHEN A.status=1 THEN 'Activo' ELSE 'Inactivo' END Status,a.id_perfil FROM QAPD_CONTROL..MANPERFILES_USUARIOS A INNER JOIN QAPD_CONTROL..MANPERFILES B ON A.id_perfil=B.id_perfil INNER JOIN MasterProfitProA..MpUsuario C ON A.usuario COLLATE SQL_Latin1_General_CP1_CI_AS=C.Cod_Usuario ORDER BY C.Desc_Usuario"
        Dim comandoSQLUsuarioPerfil As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
        comandoSQLUsuarioPerfil.CommandType = CommandType.Text
        AdaptadorUsuarPerfil = New System.Data.SqlClient.SqlDataAdapter(comandoSQLUsuarioPerfil)
        DataSetUsuarioPerfil = New Data.DataSet("DS_USUARIOPERFIL")

        AdaptadorUsuarPerfil.Fill(DataSetUsuarioPerfil, "DS_USUARIOPERFIL")
        GRID_USUARIOPERFIL.DataSource = DataSetUsuarioPerfil.Tables("DS_USUARIOPERFIL")

        GRID_USUARIOPERFIL.ReadOnly = True
        GRID_USUARIOPERFIL.DefaultCellStyle.BackColor = Color.LemonChiffon
        GRID_USUARIOPERFIL.Columns(0).Visible = False
        GRID_USUARIOPERFIL.Columns(4).Visible = False
        GRID_USUARIOPERFIL.Columns(1).Width = 150
        GRID_USUARIOPERFIL.Columns(2).Width = 200

        StrSQL = "SELECT B.Cod_Usuario,B.Desc_Usuario,C.sucursal FROM (SELECT DISTINCT usuario FROM QAPD_CONTROL..MANPERFILES_USUARIOS) AS A INNER JOIN MasterProfitProA.DBO.MpUsuario B ON A.usuario COLLATE SQL_Latin1_General_CP1_CI_AS =B.Cod_Usuario INNER JOIN QAPD_CONTROL..MANUSUARIOS_SUCURSAL C ON B.COD_USUARIO=C.USUARIO COLLATE SQL_Latin1_General_CP1_CI_AS "
        Dim comandoSQLUsuarioSucursal As System.Data.SqlClient.SqlCommand = New SqlClient.SqlCommand(StrSQL, con)
        comandoSQLUsuarioSucursal.CommandType = CommandType.Text
        AdaptadorUsuarSucursal = New System.Data.SqlClient.SqlDataAdapter(comandoSQLUsuarioSucursal)
        DataSetUsuarioSucursal = New Data.DataSet("DS_USUARIOSUCURSAL")
        AdaptadorUsuarSucursal.Fill(DataSetUsuarioSucursal, "DS_USUARIOSUCURSAL")
        GRID_SUCURSAL.DataSource = DataSetUsuarioSucursal.Tables("DS_USUARIOSUCURSAL")
        GRID_SUCURSAL.ReadOnly = True
        GRID_SUCURSAL.DefaultCellStyle.BackColor = Color.LemonChiffon
        GRID_SUCURSAL.Columns(1).Width = 200
    End Sub

    Private Sub FrmCtrlAcceso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarAcceso()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        BS_ACCESOS.EndEdit()
        AdaptadorAcceso.Update(DataSetAcceso, "DS_ACCESO")
        DataSetAcceso.Tables("DS_ACCESO").Clear()
        AdaptadorAcceso.Fill(DataSetAcceso, "DS_ACCESO")
        CargarAcceso()
        MsgBox("datos Guardados", MsgBoxStyle.Information, "SisSalud")
    End Sub

    Private Sub GRID_USUARIOPERFIL_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_USUARIOPERFIL.CellEnter
        FilaUsuarioPerfil = e.RowIndex
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If FilaUsuarioPerfil < 0 Then Exit Sub
        If MsgBox("Usted Procedera a " & IIf(GRID_USUARIOPERFIL.Item(3, FilaUsuarioPerfil).Value = "Activo", "Inactivar", "Activar") & " el perfil " & GRID_USUARIOPERFIL.Item(2, FilaUsuarioPerfil).Value & " al usuario " & GRID_USUARIOPERFIL.Item(1, FilaUsuarioPerfil).Value & ". Desea Continuar?", MsgBoxStyle.YesNo, "Confirmacion") <> MsgBoxResult.Yes Then Exit Sub
        StrSQL = "UPDATE QAPD_CONTROL..MANPERFILES_USUARIOS SET STATUS=CASE WHEN A.STATUS=1 THEN 0 ELSE 1 END FROM QAPD_CONTROL..MANPERFILES_USUARIOS A INNER JOIN QAPD_CONTROL..MANPERFILES B ON A.ID_PERFIL=B.ID_PERFIL WHERE A.USUARIO='" & GRID_USUARIOPERFIL.Item(0, FilaUsuarioPerfil).Value & "' AND B.NOMBRE='" & GRID_USUARIOPERFIL.Item(2, FilaUsuarioPerfil).Value & "'"
        ProcesarModificacion(StrSQL)
        MDIPrincipal.CargarPerfil()
        CargarAcceso()
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        If FilaUsuarioPerfil < 0 Then Exit Sub
        If MsgBox("Usted se dispone a Agregar un nuevo perfil al usuario " & GRID_USUARIOPERFIL.Item(1, FilaUsuarioPerfil).Value & ". Desea Continuar?", MsgBoxStyle.YesNo, "Confirmacion") <> MsgBoxResult.Yes Then Exit Sub
        Dim Perfil As String = InputBox("Indique el nombre del perfil a agregar. Se recomienda copiar de la tabla ACCESOS", "Nombre de Perfil a Agregar")
        If Len(Perfil) < 5 Then Exit Sub
        StrSQL = "SELECT ID_PERFIL FROM QAPD_CONTROL..MANPERFILES WHERE NOMBRE='" & Perfil & "'"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim ArregloPerfil As SqlDataReader = cmd.ExecuteReader
        While ArregloPerfil.Read
            StrSQL = "DELETE QAPD_CONTROL..MANPERFILES_USUARIOS WHERE ID_PERFIL=" & ArregloPerfil("ID_PERFIL") & " AND USUARIO='" & GRID_USUARIOPERFIL.Item(0, FilaUsuarioPerfil).Value & "' " _
            & " INSERT QAPD_CONTROL..MANPERFILES_USUARIOS (USUARIO,ID_PERFIL,STATUS) VALUES ('" & GRID_USUARIOPERFIL.Item(0, FilaUsuarioPerfil).Value & "'," & ArregloPerfil("ID_PERFIL") & ",1)"
            ProcesarModificacion(StrSQL)
            MDIPrincipal.CargarPerfil()
            CargarAcceso()
        End While
    End Sub

    Private Sub GRID_USUARIOS_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID_USUARIOS.CellEnter
        FilaUsuario = e.RowIndex
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If FilaUsuario < 0 Then Exit Sub
        If MsgBox("Usted se dispone a Deshabilitar al usuario " & GRID_USUARIOS.Item(1, FilaUsuario).Value & ". Desea Continuar?", MsgBoxStyle.YesNo, "Confirmacion") <> MsgBoxResult.Yes Then Exit Sub
        StrSQL = "UPDATE QAPD_CONTROL..MANPERFILES_USUARIOS SET STATUS=0 WHERE USUARIO='" & GRID_USUARIOS.Item(0, FilaUsuario).Value & "'"
        ProcesarModificacion(StrSQL)
        CargarAcceso()
        MDIPrincipal.CargarPerfil()

    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        If FilaUsuario < 0 Then Exit Sub
        If MsgBox("Usted se dispone a convertir al usuario " & GRID_USUARIOS.Item(1, FilaUsuario).Value & " en un usuario SisSalud. Desea Continuar?", MsgBoxStyle.YesNo, "Confirmacion") <> MsgBoxResult.Yes Then Exit Sub
        StrSQL = "DECLARE @COD_USUARIO VARCHAR(MAX)='" & GRID_USUARIOS.Item(0, FilaUsuario).Value & "' IF NOT EXISTS(SELECT USUARIO FROM QAPD_CONTROL..MANPERFILES_USUARIOS WHERE USUARIO=@COD_USUARIO) BEGIN INSERT QAPD_CONTROL..MANPERFILES_USUARIOS (ID_PERFIL,USUARIO,STATUS) VALUES (16,@COD_USUARIO,1) END"
        ProcesarModificacion(StrSQL)
        CargarAcceso()
        MDIPrincipal.CargarPerfil()

    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        If FilaUsuario < 0 Then Exit Sub
        If MsgBox("Usted se dispone a copiar un perfil de usuario a otro. Esta accion eliminara los accesos del usuario destino (si los tiene) y heredara los permidos del usuario origen . Desea Continuar?", MsgBoxStyle.YesNo, "Confirmacion") <> MsgBoxResult.Yes Then Exit Sub
        Dim Origen As String = InputBox("Indique el codigo del usuario a Copiar o Usuario Origen", "Usuario Origen")
        Dim Destino As String = InputBox("Indique el codigo del usuario al cual le desea copiar el perfil", "Usuario Destino")
        StrSQL = "DECLARE @ORIGEN VARCHAR(MAX)='" & Origen & "',@DESTINO VARCHAR(MAX)='" & Destino & "' " _
        & " DELETE QAPD_CONTROL..MANPERFILES_USUARIOS WHERE usuario=@DESTINO " _
        & " INSERT QAPD_CONTROL..MANPERFILES_USUARIOS (usuario,id_perfil,status) SELECT @DESTINO USUARIO,ID_PERFIL,STATUS FROM QAPD_CONTROL..MANPERFILES_USUARIOS WHERE usuario=@ORIGEN " _
        & " DELETE QAPD_CONTROL..MANUSUARIOS_SUCURSAL WHERE usuario=@DESTINO " _
        & " INSERT QAPD_CONTROL..MANUSUARIOS_SUCURSAL (usuario,sucursal,status) SELECT @DESTINO,SUCURSAL,STATUS FROM QAPD_CONTROL..MANUSUARIOS_SUCURSAL WHERE usuario=@ORIGEN "
        ProcesarModificacion(StrSQL)
        CargarAcceso()
        MDIPrincipal.CargarPerfil()
    End Sub

    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
        Dim strSucursal As String = InputBox("Por favor, indique el codigo de la sucursal", "Sucursal")
        Dim Usuar As String = InputBox("Por favor, indique el codigo del usuario", "Usuario")
        StrSQL = "SELECT usuario from QAPD_CONTROL..MANPERFILES_USUARIOS WHERE usuario='" & Usuar & "'"
        Dim con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection("Data Source=" & Servidor & ";Initial Catalog=" & BDEmpresa & ";User ID=" & UserSystem & ";Password=" & PasswordSystem)
        Dim cmd As SqlCommand = con.CreateCommand()
        con.Open()
        cmd.CommandText = StrSQL
        Dim ArregloPerfil As SqlDataReader = cmd.ExecuteReader
        While ArregloPerfil.Read
            StrSQL = "DELETE QAPD_CONTROL..MANUSUARIOS_SUCURSAL WHERE usuario='" & Usuar & "' AND sucursal='" & strSucursal & "' " _
            & " INSERT QAPD_CONTROL..MANUSUARIOS_SUCURSAL (usuario,sucursal,status) VALUES ('" & Usuar & "','" & strSucursal & "',1)"
            ProcesarModificacion(StrSQL)
            CargarAcceso()
        End While

    End Sub
End Class