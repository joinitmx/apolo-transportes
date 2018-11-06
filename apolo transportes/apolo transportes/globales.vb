Imports MySql.Data.MySqlClient

Module globales

    Public cn As New MySqlConnection(ConfigurationManager.AppSettings("Conexion"))

End Module
