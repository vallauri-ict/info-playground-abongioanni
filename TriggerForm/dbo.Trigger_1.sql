CREATE TRIGGER UpdateField
    ON Driver AFTER UPDATE
    AS
    BEGIN
        DECLARE @number_old as INT
        DECLARE @number_new as INT
        DECLARE @full_name_old as VARCHAR(100)
        DECLARE @full_name_new as VARCHAR(100)
        DECLARE @country_old as CHAR(2)
        DECLARE @country_new as CHAR(2)
		DECLARE @date_birth_old as DATE
        DECLARE @date_birth_new as DATE
        DECLARE @team_id_old as INT
        DECLARE @team_id_new as INT
        DECLARE @podiums_number_old as INT
        DECLARE @podiums_number_new as INT

        SET @number_old = (select number from deleted)
        SET @number_new = (select number from inserted)
        SET @full_name_old = (select full_name from deleted)
        SET @full_name_new = (select full_name from inserted)
        SET @country_old = (select country from deleted)
        SET @country_new = (select country from inserted)
		SET @date_birth_old = (select date_birth from deleted)
        SET @date_birth_new = (select date_birth from inserted)
        SET @team_id_old = (select team_id from deleted)
        SET @team_id_new = (select team_id from inserted)
        SET @podiums_number_old = (select podiums_number from deleted)
        SET @podiums_number_new = (select podiums_number from inserted)

        if(@number_old = @number_new)
            select @number_old = NULL,
				   @number_new = NULL

        if(@full_name_old = @full_name_new)
            select @full_name_old = NULL,
			       @full_name_new = NULL

		if(@country_old = @country_new)
            select @country_old = NULL,
			       @country_new = NULL

		if(@date_birth_old = @date_birth_new)
            select @date_birth_old = NULL,
		           @date_birth_new = NULL

        if(@team_id_old = @team_id_new)
            select @team_id_old = NULL,
		           @team_id_new = NULL

        if(@podiums_number_old = @podiums_number_new)
            select @podiums_number_old = NULL,
			       @podiums_number_new = NULL

        INSERT INTO StoricoAggiornamenti(number_old, number_new, full_name_old, full_name_new, country_old,
									 country_new, date_birth_old, date_birth_new, team_id_old, 
									 team_id_new, podiums_number_old, podiums_number_new)
		VALUES(@number_old, @number_new, @full_name_old, @full_name_new, @country_old, @country_new,
			   @date_birth_old, @date_birth_new, @team_id_old, @team_id_new, @podiums_number_old, 
			   @podiums_number_new)
    END