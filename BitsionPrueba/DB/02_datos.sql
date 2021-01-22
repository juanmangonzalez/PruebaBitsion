USE [BitsionPrueba]
GO
INSERT INTO [dbo].[Users] ([Nombre]) VALUES ('Luis')
INSERT INTO [dbo].[Users] ([Nombre]) VALUES ('David')
INSERT INTO [dbo].[Users] ([Nombre]) VALUES ('Alejandra')

INSERT INTO [dbo].[PlayLists] ([Nombre],[CantidadCanciones],[Duracion]) VALUES ('Lo mejor del reggae',23,'01:22:45')
INSERT INTO [dbo].[PlayLists] ([Nombre],[CantidadCanciones],[Duracion]) VALUES ('Grandes exitos Rolling Stones',20,'00:55:07')
INSERT INTO [dbo].[PlayLists] ([Nombre],[CantidadCanciones],[Duracion]) VALUES ('Folclore Nacional',15,'00:49:52')
INSERT INTO [dbo].[PlayLists] ([Nombre],[CantidadCanciones],[Duracion]) VALUES ('Latinos 2020',33,'01:42:02')
INSERT INTO [dbo].[PlayLists] ([Nombre],[CantidadCanciones],[Duracion]) VALUES ('Operas y Sonatas',12,'02:19:53')

INSERT INTO [dbo].[PlayList_X_User] ([PlayListID],[UserID]) VALUES (1,2)
INSERT INTO [dbo].[PlayList_X_User] ([PlayListID],[UserID]) VALUES (1,3)
INSERT INTO [dbo].[PlayList_X_User] ([PlayListID],[UserID]) VALUES (2,1)
INSERT INTO [dbo].[PlayList_X_User] ([PlayListID],[UserID]) VALUES (2,2)
INSERT INTO [dbo].[PlayList_X_User] ([PlayListID],[UserID]) VALUES (3,1)
INSERT INTO [dbo].[PlayList_X_User] ([PlayListID],[UserID]) VALUES (3,2)
INSERT INTO [dbo].[PlayList_X_User] ([PlayListID],[UserID]) VALUES (3,3)
INSERT INTO [dbo].[PlayList_X_User] ([PlayListID],[UserID]) VALUES (4,3)

