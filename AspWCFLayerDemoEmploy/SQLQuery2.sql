IF EXISTS(SELECT * FROM Sysobjects WHERE Name='PrcEmpShow')
DROP PROC prcEmpShow
GO

CREATE PROC prcEmpShow 
AS
BEGIN
	SELECT * FROM Emp 
END
GO

IF EXISTS(SELECT * FROM Sysobjects WHERE Name='prcEmpSearch')
DROP PROC prcEmpSearch
GO
CREATE PROC prcEmpSearch
					@empno INT 
AS
BEGIN
	SELECT * FROM Emp WHERE Empno=@empno
END
GO

IF EXISTS(SELECT * FROM Sysobjects WHERE Name='prcEmpInsert')
DROP PROC prcEmpInsert
GO
CREATE PROC prcEmpInsert 
					@empno INT,
					@name VARCHAR(30),
					@dept VARCHAR(30),
					@desig VARCHAR(30),
					@basic INT
AS
BEGIN
	INSERT INTO EMp VALUES(@empno,@name,@dept,@desig,@basic)
END
GO

IF EXISTS(SELECT * FROM Sysobjects WHERE Name='prcEmpUpdate')
DROP PROC prcEmpUpdate
GO
CREATE PROC prcEmpUpdate
					@Empno INT,
					@Nam varchar(30),
					@Dept varchar(30),
					@Desig varchar(30),
					@Basic INT
AS
BEGIN 
	UPDATE EMP SET Nam=ISNULL(@Nam,Nam),
				   Dept=ISNULL(@Dept,Dept),
				   Desig=ISNULL(@Desig,Desig),
				   Basic=ISNULL(@Basic,Basic)
	WHERE EMPNO=@Empno 
END
GO

IF EXISTS(SELECT * FROM Sysobjects WHERE Name='prcEmpDelete')
DROP PROC prcEmpDelete
GO
CREATE PROC prcEmpDelete
					@empno INT,
					@result VARCHAR(30) OUT
AS
BEGIN
	IF EXISTS(SELECT * FROM Emp Where Empno=@empno)
	BEGIN 
		DELETE FROM Emp WHERE Empno=@empno 
		SET @result='Record Deleted...'
	END
	ElSE 
	BEGIN
		SET @result='Record not Found'
	END
END
GO