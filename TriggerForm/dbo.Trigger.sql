CREATE TRIGGER DeleteRow
    ON Driver AFTER DELETE
    AS
    INSERT INTO StoricoCancellazioni (number, full_name, country, date_birth, team_id, podiums_number)
    (SELECT d.number, d.full_name, d.country, d.date_birth, d.team_id, d.podiums_number
    FROM deleted d);
