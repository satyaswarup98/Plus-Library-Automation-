Imports MySql.Data.MySqlClient

Module Module_DataBase

    Public con As New MySqlConnection(" Server = 127.0.0.1; Port = 3306 ; Database=library_db ; User = root ; Password = ; Convert Zero Datetime=True")
    Public com As New MySqlCommand
    Public str As String
    Public dtt, dtt2 As String
    Public ds_Ready_Book, ds_RBO, ds_SV, ds_BV, ds_BV2, ds_DRV, ds_RVB, ds_SFR, ds_SR, ds_SIBR, ds_BEntry, ds_BEdit, ds_SBR, ds_SBR2, ds_SBI, ds_FBR, ds_FBR2, ds_BS, ds_FS, ds_SS As New DataSet
    Public sqlda_Ready_Book, sqlda_RBO, sqlda_SV, sqlda_BV, sqlda_SFR, sqlda_SR, sqlda_SIBR, sqlda_BV2, sqlda_DRV, sqlda_RVB, sqlda_BEdit, sqlda_BEntry, sqlda_SBR, sqlda_SBR2, sqlda_SBI, sqlda_FBR, sqlda_FBR2, sqlda_BS, sqlda_FS, sqlda_SS As MySqlDataAdapter

    Public reader As MySqlDataReader


End Module
