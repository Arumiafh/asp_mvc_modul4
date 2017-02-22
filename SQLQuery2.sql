GO
INSERT INTO SYSUser (LoginName,PasswordEncryptedText, RowCreatedSYSUserID, 
RowModifiedSYSUserID)   
VALUES ('Admin','Admin',1,1)   
GO   
INSERT INTO SYSUserProfile (SYSUserID,FirstName,LastName,Gender,RowCreatedSYSUserID, 
RowModifiedSYSUserID)   
VALUES (2,'Vinz','Durano','M',1,1)   
GO 
 
INSERT INTO SYSUserRole (SYSUserID,LOOKUPRoleID,IsActive,RowCreatedSYSUserID, 
RowModifiedSYSUserID)   
VALUES (2,1,1,1,1)   
GO