﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lessoner.SQL
{
    public static class Statements
    {
        public const string SetFirstPasswort = @"UPDATE tbanmeldung
                                                 SET Passwort = @Passwort
                                                 WHERE ID = (SELECT AnmeldungID FROM tbpasswortsetzen WHERE Parameter = @Parameter LIMIT 1);
                                                 DELETE FROM tbpasswortsetzen WHERE Parameter = @Parameter;";

        public const string CountSetPasswortParameter = @"SELECT COUNT(*) FROM tbpasswortsetzen WHERE Parameter = @Parameter";
        public const string InsertNewSetPasswortPageParameter = @"INSERT INTO tbpasswortsetzen (AnmeldungID, Parameter)
                                                                  VALUES(@AnmeldungID, @Parameter)";
        public const string CountLessons = @"SELECT COUNT(*) FROM tbfaecher";
        public const string CountClasses = @"SELECT COUNT(*) FROM tbklasse";
        public const string CountTeacher = @"SELECT COUNT(*) FROM tblehrer";
        public const string InsertNewPasswort = @"UPDATE tbanmeldung
                                                  SET Passwort = @NewPasswort
                                                  WHERE Email = @Email";
        public const string CheckPassword = @"SELECT COUNT(*) FROM tbanmeldung
                                              WHERE Email = @Email and Passwort = @Passwort";
        public const string GetTeacher = @"SELECT * FROM tblehrer";
        public const string DeleteLessonName = @"DELETE FROM tbfaecher
                                                 WHERE ID = @ID";

        public const string InsertNewLessonName = @"INSERT INTO tbfaecher (Name, NameKurz)
                                                    VALUES (@Name, @NameKurz);
                                                    SELECT LAST_INSERT_ID();";

        public const string RemoveRoom = @"DELETE FROM tbraum
                                           WHERE ID = @ID";

        public const string GetRooms = @"SELECT * FROM tbraum";

        public const string InsertRoom = @"INSERT INTO tbraum (Name)
                                           VALUES (@RaumName);
                                           SELECT LAST_INSERT_ID();";

        public const string UpdateInfo = @"UPDATE tbfachinfo
                                           SET Information = @Information
                                           WHERE ID = @ID";
        public const string DeleteFile = @"DELETE FROM tbdateien
                                           WHERE Path LIKE CONCAT('%',@FileName)";
        public const string GetFile = @"SELECT * FROM tbdateien
                                        WHERE Path LIKE CONCAT('%', @FileName)";
        public const string InsertFile = @"INSERT INTO tbdateien (FachInfoID, Path, FileName)
                                           VALUES (@LessonID, @Path, @FileName)";
        public const string GetFiles = @"SELECT * FROM tbdateien
                                         WHERE FachinfoID = @ID";
        public const string GetLessonInfoText = @"SELECT Information FROM tbfachinfo
                                                  WHERE ID = @ID";
        public const string UpdateClass = @"UPDATE tbklasse
                                            SET Name = @Name
                                            WHERE ID = @ID";
        public const string DeleteClass = @"DELETE FROM tbklasse
                                            WHERE ID = @ID";
        public const string InsertClass = @"INSERT INTO tbklasse (Name)
                                            VALUES(@Name)";
        public const string DeleteLogin = @"DELETE FROM tbanmeldung WHERE ID = @ID";
        public const string UpdateLoginName = @"UPDATE tbanmeldung
                                                SET Email = @Email
                                                WHERE ID=@AnmeldungID";
        /// <summary>
        /// Fügt einen neuen Login hinzu und gibt die id zurück
        /// </summary>
        public const string InsertNewLogin = @"INSERT INTO tbanmeldung (Email, Passwort)
                                                 VALUES(@Email, @Password);
                                                 SELECT LAST_INSERT_ID();";
        public const string InsertNewStudent = @"INSERT INTO tbschueler (Vorname, Name, Strasse, Hausnummer, PLZ, Ort, KlasseID, AnmeldungID)
                                                 VALUES (@Vorname, @Name, @Strasse, @Hausnummer, @PLZ, @Ort, @KlasseID, @AnmeldungID)";
        public const string InsertNewTeacher = @"INSERT INTO tblehrer (Titel, Vorname, Name, Strasse, Hausnummer, PLZ, Ort, AnmeldungID)
                                                 VALUES (@Titel, @Vorname, @Name, @Strasse, @Hausnummer, @PLZ, @Ort, @AnmeldungID)";
        public const string InsertNewRights = @"INSERT INTO tbrechtewert (AnmeldungID, RechtID, Wert)
                                                VALUES
                                                (@AnmeldungID, 1, @Right1),
                                                (@AnmeldungID, 2, @Right2),
                                                (@AnmeldungID, 3, @Right3),
                                                (@AnmeldungID, 4, @Right4),
                                                (@AnmeldungID, 5, @Right5),
                                                (@AnmeldungID, 6, @Right6),
                                                (@AnmeldungID, 7, @Right7),
                                                (@AnmeldungID, 8, @Right8),
                                                (@AnmeldungID, 9, @Right9),
                                                (@AnmeldungID, 10, @Right10),
                                                (@AnmeldungID, 11, @Right11),
                                                (@AnmeldungID, 12, @Right12),
                                                (@AnmeldungID, 13, @Right13),
                                                (@AnmeldungID, 14, @Right14)";
        public const string UpdateTeacher = @"UPDATE tblehrer
                                              SET Titel = @Titel, Vorname=@Vorname, Name=@Name, Strasse=@Strasse, Hausnummer=@Hausnummer, PLZ=@PLZ, Ort=@Ort
                                              WHERE AnmeldungID=@AnmeldungID";
        public const string UpdateStudent = @"UPDATE tblehrer
                                              SET Vorname=@Vorname, Name=@Name, Strasse=@Strasse, Hausnummer=@Hausnummer, PLZ=@PLZ, Ort=@Ort
                                              WHERE AnmeldungID=@AnmeldungID";

        public const string UpdateRights = @"UPDATE tbrechtewert SET Wert=@Right1 WHERE RechtID=2 AND AnmeldungID=@AnmeldungID;
                                             UPDATE tbrechtewert SET Wert=@Right2 WHERE RechtID=3 AND AnmeldungID=@AnmeldungID;
                                             UPDATE tbrechtewert SET Wert=@Right3 WHERE RechtID=4 AND AnmeldungID=@AnmeldungID;
                                             UPDATE tbrechtewert SET Wert=@Right4 WHERE RechtID=5 AND AnmeldungID=@AnmeldungID;
                                             UPDATE tbrechtewert SET Wert=@Right5 WHERE RechtID=6 AND AnmeldungID=@AnmeldungID;
                                             UPDATE tbrechtewert SET Wert=@Right6 WHERE RechtID=7 AND AnmeldungID=@AnmeldungID;
                                             UPDATE tbrechtewert SET Wert=@Right7 WHERE RechtID=8 AND AnmeldungID=@AnmeldungID;
                                             UPDATE tbrechtewert SET Wert=@Right8 WHERE RechtID=9 AND AnmeldungID=@AnmeldungID;
                                             UPDATE tbrechtewert SET Wert=@Right9 WHERE RechtID=10 AND AnmeldungID=@AnmeldungID;
                                             UPDATE tbrechtewert SET Wert=@Right10 WHERE RechtID=11 AND AnmeldungID=@AnmeldungID;
                                             UPDATE tbrechtewert SET Wert=@Right11 WHERE RechtID=12 AND AnmeldungID=@AnmeldungID;
                                             UPDATE tbrechtewert SET Wert=@Right12 WHERE RechtID=13 AND AnmeldungID=@AnmeldungID;
                                             UPDATE tbrechtewert SET Wert=@Right13 WHERE RechtID=14 AND AnmeldungID=@AnmeldungID;";

        public const string ConnectionString = @"Server=127.0.0.1;Database=dbLessoner;Uid=root;Pwd=;";

        //TODO: Ordnen(?)
        //Nein
        public const string CheckForLessoner = @"SELECT COUNT(s.ID) FROM tbstundenplan as s
                                                 WHERE s.KlasseID = @KlasseID AND s.Datum = @Datum ";

        public const string GetLessonerID = @"SELECT ID FROM tbstundenplan as s
                                              WHERE s.KlasseID = @KlasseID AND s.Datum = @Datum";

        public const string InsertEmptyLessoner = @"INSERT INTO tbstundenplan (Datum, KlasseID, FaecherverteilungID)
                                                    VALUES(@Datum, @KlasseID, 0);

                                                    INSERT INTO tbTage (TagInfoID, StundenplanID, FindetStatt)
                                                    VALUES
                                                    (1,(SELECT ID FROM tbStundenplan WHERE Datum = @Datum and KlasseID = @KlasseID LIMIT 1), 1),
                                                    (2,(SELECT ID FROM tbStundenplan WHERE Datum = @Datum and KlasseID = @KlasseID LIMIT 1), 1),
                                                    (3,(SELECT ID FROM tbStundenplan WHERE Datum = @Datum and KlasseID = @KlasseID LIMIT 1), 1),
                                                    (4,(SELECT ID FROM tbStundenplan WHERE Datum = @Datum and KlasseID = @KlasseID LIMIT 1), 1),
                                                    (5,(SELECT ID FROM tbStundenplan WHERE Datum = @Datum and KlasseID = @KlasseID LIMIT 1), 1);";
        /// <summary>
        /// Gibt die Rechte und die ID des Benutzers zurück. @Email = die Email, @Passwort = Das mit SHA-1 Gehashte Passwort in einer länge von 20byte
        /// </summary>
        public const string GetUserRights = @"SELECT a.ID as LoginID, b.`Group` as RechtGruppe, b.Name as RechtName,r.Wert as RechtWert
                                                FROM tbanmeldung as a
                                                JOIN tbrechtewert as r
                                                ON r.AnmeldungID  = a.ID
                                                JOIN tbrechtebeschreibung as b
                                                ON b.ID = r.RechtID
                                                WHERE a.Email=@Email AND a.Passwort = @Passwort";

        public const string GetStudentRights = @"SELECT a.ID as LoginID, b.`Group` as RechtGruppe, b.Name as RechtName,r.Wert as RechtWert
                                                 FROM tbanmeldung as a
                                                 JOIN tbschueler as s
                                                 ON s.AnmeldungID=a.ID
                                                 JOIN tbrechtewert as r
                                                 ON r.AnmeldungID  = a.ID
                                                 JOIN tbrechtebeschreibung as b
                                                 ON b.ID = r.RechtID
                                                 WHERE s.ID=@SchuelerID
                                                 ORDER BY b.ID";

        public const string GetTeacherRights = @"SELECT a.ID as LoginID, b.`Group` as RechtGruppe, b.Name as RechtName,r.Wert as RechtWert
                                                 FROM tbanmeldung as a
                                                 JOIN tblehrer as l
                                                 ON l.AnmeldungID=a.ID
                                                 JOIN tbrechtewert as r
                                                 ON r.AnmeldungID  = a.ID
                                                 JOIN tbrechtebeschreibung as b
                                                 ON b.ID = r.RechtID
                                                 WHERE l.ID=@LehrerID
                                                 ORDER BY b.ID";

        public const string GetAllRights = @"SELECT * FROM tbrechtebeschreibung
                                             ORDER BY ID";

        /// <summary>
        /// Gibt die Informationen eines Lehrers Zurück. @LoginID = Die Anmelde ID des Lehrers
        /// </summary>
        /// 
        public const string GetTeacherInfos = @"SELECT l.ID, a.Email, l.Titel, l.Vorname, l.Name, l.Strasse, l.Hausnummer, l.PLZ, l.Ort, l.KlasseID FROM tbanmeldung as a
                                                JOIN tblehrer as l
                                                ON l.AnmeldungID = a.ID
                                                WHERE a.ID = @LoginID";

        public const string GetStudentList = @"SELECT s.ID, s.AnmeldungID, a.Email, s.Vorname, s.Name, s.Strasse, s.Hausnummer, s.PLZ, s.Ort, s.KlasseID, k.Name as KlassenName
                                               FROM tbanmeldung as a
                                               JOIN tbschueler as s
                                               ON s.AnmeldungID = a.ID
                                               JOIN tbklasse as k ON s.KlasseID = k.ID
                                               WHERE k.ID=@KlasseID";

        public const string GetTeacherList = @"SELECT l.Titel, l.ID, l.AnmeldungID, a.Email, l.Vorname, l.Name, l.Strasse, l.Hausnummer, l.PLZ, l.Ort, l.KlasseID as KlassenName
                                                FROM tbanmeldung as a
                                                JOIN tblehrer as l
                                                ON l.AnmeldungID = a.ID";

        public const string GetStudentInfos = @"SELECT s.ID, a.Email, s.Vorname, s.Name, s.Strasse, s.Hausnummer, s.PLZ, s.Ort, s.KlasseID, k.Name as KlassenName
                                                FROM tbanmeldung as a
                                                JOIN tbschueler as s
                                                ON s.AnmeldungID = a.ID
                                                JOIN tbklasse as k ON s.KlasseID = k.ID
                                                WHERE a.ID = @LoginID";

        public const string GetStudentProfile = @"SELECT s.ID, a.Email, s.Vorname, s.Name, s.Strasse, s.Hausnummer, s.PLZ, s.Ort, s.KlasseID, kl.Name, a.Path
                                                  FROM tbanmeldung AS a
                                                  JOIN tbschueler AS s
	                                                  ON s.AnmeldungID = a.ID
                                                  JOIN tbklasse AS kl
	                                                  ON kl.ID = s.KlasseID
                                                  WHERE a.ID = @LoginID";


        public const string SetAnmeldung = @"INSERT INTO tbanmeldung (EMail, Passwort)
                                             VALUES (@EMail, @Passwort)";

        public const string SetStudent = @"INSERT INTO tbanmeldung (EMail, Passwort)
                                           VALUES (@Email, @Passwort);
                                           INSERT INTO tbschueler (Vorname, Name, Strasse, Hausnummer, PLZ, Ort, KlasseID, AnmeldungID)
                                           VALUES (@Vorname, @Name, @Strasse, @Hausnummer, @PLZ, @Stadt,1, LAST_INSERT_ID())";

        public const string SetTeacher = @"INSERT INTO tblehrer (Titel, Vorname, Name, Strasse, Hausnummer, PLZ, Ort, KlasseID, AnmeldungID)
                                           VALUES (@Titel, @Vorname, @Name, @Strasse, @Hausnummer, @PLZ, @Ort, @KlasseID, SELECT ID
																		                                                  FROM tbanmeldung
																		                                                  WHERE Email = @Email)";

        /*
                                              .ooOOOOo.  .oOOOOOOo
                                            .oOOOooooooo oOOOOOOOOOO oo.
                                         .ooooooOOOOOO oOOoO @@) OO OOOo.
                                   .oooOOOOOOOOOOOOOO OO oO       OO OOOOo
                             .ooOOOOOOOOOOOOOOOOOOOO O oOOO.     .OO OOOOOO
                         .ooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOo. .oOOO OOOOOO
                       oOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO oOOOOOOO
                     .OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOooooooOOOOOOOOO
                    .OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                   .OoOOOOOOOooOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO'
                   OOOOOOOOOOOOOOOOOOO /\/\/\/\/\/\/\/\/ OOOOOOOOOOOOOOO"
                   `OOOOOOOOOOO /\/\/\/    /\/\/\/\/\/\ oOOOOOOOOOOOOOO'
                     /\/\/\/\/\/      /\/\/\/\/\ ooooooOOOOOOOOOOOOOO"
                                /\/\/\/\/\ oooooOOOOOOOOOOOOOOOOOOOOO
                          \/\/\/\/\/ oooooOOOOOOOOOOOO"'ooooooOOOOOOO
                           `""OOOOOOOOOOOOOOOO"'.ooooooOOOOOOOOOOOOOOO
                                              .OOOOOOOOOOOOOOOOOOOOOOOO
                                            .oOOOOOOOOOOOOOOOOOOOOOOOOOOo
                                        ..oOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                                  ..oooOOOoOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                           ..oooOOOOOOOOoOOOOOOOOOOOOOOOOOOOO"" OOOOOOO oOO
                     .oooOOOOOOOO"""   oOOOOOOOOOOOOOOOO"  ooOOOOOOOOO oOOO
                     OO `O           .OOOOOOOOOOOOOOOO   ooooooooooooooOOO
                     `O             .OOOOOOOOOOOOOOOO OO OOOOOOOOOOOOOOOO
                .oO                 OOOOOOOOOOOOOOOOO OOOOOOOOOOOOOOOOOOO
              .oOO'                 OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
             oOOO'                  OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
           .OOOO'                   oOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
           OOOO'                  .oooOOOOOOOOOOOOOOOOOOOOOOOOOOOooOOOOOOOOo.
           OOOO                .oOOOOOooOOOOOOOOOOOOOOOOOOOOooOOOOOOOOOOOOOoOo
           OOOO.             .oOOOOOOOOOooOOOOOOOOOOOOOOooOOOOOOOOOOOOOOOOOoOO
           OOOOO.          .oOOOOOOOOOOOOOOoooOOOOOOOOoOOOOOOOOOOOOOOOOOOOOoOO
           OOOOOO.        .OOOOOOOOOOOOOOOOOOOOooo  OOOOOOOOOOOOOOOOOOOOOOO OO
           `OOOOOO.      .OOOOOOOOOOOOOOOOOOOO"'     `OOOOOOOOOOOOOOOOOOOOO OO
            `OOOOOOo.    OOOOOOOOOOOOOOOOOOO"          `OOOOOOOOOOOOOOOOOO OOO
             `OOOOOOOOo. OOOOOOOOOOOOOOOOO"       ..ooOOO`OOOOOOOOOOOOOOOO OOO
               "OOOOOOOOO`OOOOOOOOOOOOOOo.OOOOOOOOOOOOOOOOO`OOOOOOOOOOOOO OOOO
                 "OOOOOOOOOo"OOOOOOOOOOOOOOo.OOOOOOOOOOOOOOO`OOOOOOOOOOO OOOO'
                    `"OOOOOOOOo"OOOOOOOOOOOOOoo.OOOOOOOOOOOO OOOOOOOOOOO OO'
                         `"OOOOOOOo"OOOOOOOOOOOOOo.OOOOOOOOO OOOOOOOOOOOO.
                                       `"OOOOOOOOOOOOo.      OOOoooooOOOOO
                                 ...ooooooooooOOOOOOOOOO.    `OOOOOOOOOOOO
                             .oOOOOOOOOOOOOOOOOOOOOOOOOOO     `OOOOOOOOOO'
                            /  OOOOO oO/~~~\OOOOOO/~~~\OO       `OOOOOOOO
                           | _OOOOOO O|     |O OO|     |'        OOOOOOO'
                           |/          \   /      \   /        .oOOOOOO'
                                         \|        |/    .oooOOOOOOOOOOOo
                                                     .oOOOOOOOOOOOOOOOOOOOo
                                                    /  OOO oO/~~~\OOOOO/~~\O
                                                   | _OOOO O|     |O O|    |'
                                                   |/        \   /     \  /
                                                              \ /       \/
                                                              
*/

        //Because dinosaurs are fucking cool!

        public const string DeleteLessonsFromDay = @"DELETE FROM tbfachinfo
                                                     WHERE TagID = @TagID";
        public const string SetClass = @"INSERT INTO tbklasse (Name)
                                         VALUES (@Name)";

        public const string GetStudents = @"SELECT s.Vorname, s.Name, s.Strasse, s.Hausnummer, s.PLZ, s.Ort
                                            FROM tbschueler AS s
                                            JOIN tbklasse AS k
	                                            ON s.KlasseID = k.ID
                                            WHERE k.Name = @Klasse
                                            ORDER BY s.Name ";

        public const string GetLessonerBuilder = @"SELECT ti.ID as TagInfoID, t.Information, fi.ID as FachID, f.Name, f.NameKurz, fm.ID as FachModID, t.FindetStatt, fi.Stunde_Beginn, fi.Stunde_Ende FROM tbklasse as k
                                                   JOIN tbstundenplan as s ON s.KlasseID = k.ID
                                                   JOIN tbtage as t ON t.StundenplanID = s.ID
                                                   JOIN tbtaginfo as ti ON ti.ID = t.TagInfoID
                                                   Left JOIN tbfachinfo as fi ON t.ID = fi.TagID
                                                   Left JOIN tbfaecher as f ON f.ID = fi.FachID
                                                   Left JOIN tbfachmod as fm ON fi.FachModID = fm.ID
                                                   WHERE k.ID = @KlasseID AND s.Datum = @Datum
                                                   ORDER BY t.ID";

        public const string LessonerBuilderGetTeacher = @"SELECT ID, Name FROM tblehrer";
        public const string LessonerBuilderGetLessonNames = @"SELECT ID, Name FROM tbfaecher";
        public const string LessonerBuilderGetLessonMods = @"SELECT ID, Bezeichnung FROM tbfachmod";

        public const string UpdateLesson = @"UPDATE tbfachinfo 
                                             SET LehrerID = @LehrerID, FachID = @FachID, Stunde_Beginn = @StundeBeginn, Stunde_Ende = @StundeEnde, FachModID = @FachModID, RaumID = @RaumID
                                             WHERE ID = @ID";

        public const string InsertDefaultLesson = @"INSERT INTO tbfachinfo (LehrerID, FachID, TagID, Stunde_Beginn, Stunde_Ende, FachModID)
                                                    VALUES ((SELECT ID FROM tblehrer LIMIT 1), (SELECT ID FROM tbfaecher LIMIT 1), @TagID, @Stunde, @Stunde, (SELECT ID FROM tbfachmod LIMIT 1));
                                                    ";
        public const string UpdateDay = @"UPDATE tbtage
                                          SET FindetStatt = @FindetStatt, Information = @Information
                                          WHERE ID = @ID;";
        /// <summary>
        /// Gibt zurück ob ein Tag Statt findet oder nicht
        /// </summary>
        public const string GetDayInformations = @"SELECT t.ID as TagID, ti.ID as TagInfoID, t.Information, t.FindetStatt FROM tbstundenplan as s
                                                   JOIN tbtage as t ON t.StundenplanID = s.ID
                                                   JOIN tbtaginfo as ti ON ti.ID = t.TagInfoID
                                                   WHERE s.KlasseID = @KlasseID AND s.Datum = @Datum
                                                   ORDER BY t.ID";
        public const string GetDayIDs = @"SELECT t.ID, t.TagInfoID FROM tbtage as t
                                          WHERE t.StundenplanID = @StundenplanID
                                          ORDER BY t.ID";
        
        public const string GetLessonPerDayTeacher = @"SELECT fi.*, f.Name as FachName, f.NameKurz as FachNameKurz, t.TagInfoID, r.ID as RaumID, r.Name as RaumName 
                                                       FROM tbtage as t
                                                       JOIN tbfachinfo as fi ON t.ID = fi.TagID
                                                       JOIN tbfaecher as f ON fi.FachID = f.ID
                                                       JOIN tblehrer as l ON l.ID = fi.LehrerID
                                                       JOIN tbstundenplan as s ON s.ID =  t.StundenplanID
                                                       LEFT JOIN tbraum as r on fi.RaumID = r.ID
                                                       WHERE l.ID = @LehrerID AND t.TagInfoID=@TagInfoID AND s.Datum = @Woche
                                                       ORDER BY Stunde_Beginn";

        public const string GetLessonPerDay = @"SELECT fi.*, f.Name as FachName, f.NameKurz as FachNameKurz, t.TagInfoID, r.ID as RaumID, r.Name as RaumName, l.Name as Lehrername FROM tbtage as t
                                                JOIN tbfachinfo as fi ON t.ID = fi.TagID
                                                JOIN tbfaecher as f ON fi.FachID = f.ID
                                                LEFT JOIN tbraum as r on fi.RaumID = r.ID
                                                LEFT JOIN tblehrer as l on l.ID = fi.LehrerID
                                                WHERE t.ID = @TagID
                                                ORDER BY Stunde_Beginn";

        public const string DeleteLesson = @"DELETE FROM tbfachinfo WHERE ID = @ID";

        public const string GetClasses = @"SELECT * FROM tbKlasse AS k ORDER BY k.Name";

        public const string CountLessoner = @"SELECT COUNT(s.ID) as Anzahl FROM tbklasse as k
                                              JOIN tbstundenplan as s ON k.ID = s.KlasseID
                                              WHERE k.ID = @KlasseID AND s.Datum = @Datum";

        public const string GetFaecherverteilung = @"SELECT * FROM tbfaecherverteilung ORDER BY Stunde";

        public const string SetRights = @"INSERT INTO tbrechtewert (AnmeldungID, RechteID, Wert)
                                          VALUES (SELECT ID FROM tbanmeldung WHERE EMail = @EMail, SELECT ID FROM tbrechtebeschreibung 
                                          WHERE `Group` = @RechtGruppe AND Name = @RechtName, @Value)";
        public const string InsertLesson = @"INSERT INTO tbfachinfo (LehrerID, FachID, TagID, Stunde_Beginn, Stunde_Ende, FachModID)
                                             VALUES(@LehrerID, @FachID, @TagID, @Stunde_Beginn, @Stunde_Ende, @FachModID)";
        //TODO: Testen, Ausgabe soll der Pfad der Datei sein
        //ACHTUNG BEI MERGE: Fehler wurde korrigiert (Falsche id bei ON). Muss immer noch getestet werden
        public const string GetData = @"SELECT Path
                                        FROM tbdateien	AS da
                                        JOIN tbfachinfo AS fi
	                                        ON da.FachinfoID = fi.ID
                                        WHERE FachinfoID = @Fachinfo ";


        /// <summary>
        /// Achtung! 5 mal das selbe für die 5 Tage im Lessoner.aspx
        /// </summary>
        public const string GetDays = @"SELECT ta.FindetStatt, fa.Name, le.Titel, le.Vorname, le.Name AS Nachname, fi.Stunde_Beginn, fi.Stunde_Ende, fv.Stunde, fv.Uhrzeit, ti.Name AS TagName
                                        FROM tbstundenplan AS st
                                        JOIN tbklasse AS kl
	                                        ON kl.ID = st.KlasseID
                                        JOIN tbtage AS ta
	                                        ON ta.StundenplanID = st.ID
                                        JOIN tbtaginfo AS ti
	                                        ON ti.ID = ta.TagInfoID
                                        JOIN tbfachinfo AS fi
	                                        ON fi.TagID = ta.ID
                                        JOIN tbfaecher AS fa
	                                        ON fa.ID = fi.FachID
                                        JOIN tbfachmod AS fm
	                                        ON fm.ID = fi.FachModID
                                        JOIN tblehrer AS le
	                                        ON fi.LehrerID = le.ID
                                        JOIN tbfaecherverteilung AS fv
	                                        ON fv.Stunde = fi.Stunde_Beginn
                                        WHERE ti.ID = @i AND st.KlasseID = @KlassenID
                                        ORDER BY fv.Stunde ASC";

        //TODO: Kann das weg?
        //Nein
        //Immer Das Letzte Statement (da sehr lang)
        public const string CreateDatabase = @"-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server Version:               5.5.27 - MySQL Community Server (GPL)
-- Server Betriebssystem:        Win32
-- HeidiSQL Version:             8.2.0.4675
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Exportiere Datenbank Struktur für dblessoner
DROP DATABASE IF EXISTS `dblessoner`;
CREATE DATABASE IF NOT EXISTS `dblessoner` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `dblessoner`;


-- Exportiere Struktur von Tabelle dblessoner.tbanmeldung
DROP TABLE IF EXISTS `tbanmeldung`;
CREATE TABLE IF NOT EXISTS `tbanmeldung` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Email` varchar(45) NOT NULL,
  `Passwort` varbinary(16) NOT NULL,
  `RechteID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `RechteID_idx` (`RechteID`),
  CONSTRAINT `RechteID` FOREIGN KEY (`RechteID`) REFERENCES `tbrechte` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tbanmeldung: ~3 rows (ungefähr)
DELETE FROM `tbanmeldung`;
/*!40000 ALTER TABLE `tbanmeldung` DISABLE KEYS */;
INSERT INTO `tbanmeldung` (`ID`, `Email`, `Passwort`, `RechteID`) VALUES
	(1, 'test', _binary 0x7110EDA4D09E062AA5E4A390B0A572AC0D2C0220, 0),
	(2, 'lehrer', _binary 0x7110EDA4D09E062AA5E4A390B0A572AC0D2C0220, 2),
	(3, 'schueler', _binary 0x7110EDA4D09E062AA5E4A390B0A572AC0D2C0220, 1);
/*!40000 ALTER TABLE `tbanmeldung` ENABLE KEYS */;


-- Exportiere Struktur von Tabelle dblessoner.tbdateien
DROP TABLE IF EXISTS `tbdateien`;
CREATE TABLE IF NOT EXISTS `tbdateien` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `FachinfoID` int(11) NOT NULL,
  `Path` varchar(128) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_tbDateien_tbFachinfo_idx` (`FachinfoID`),
  CONSTRAINT `fk_tbDateien_tbFachinfo` FOREIGN KEY (`FachinfoID`) REFERENCES `tbfachinfo` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tbdateien: ~0 rows (ungefähr)
DELETE FROM `tbdateien`;
/*!40000 ALTER TABLE `tbdateien` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbdateien` ENABLE KEYS */;


-- Exportiere Struktur von Tabelle dblessoner.tbfachinfo
DROP TABLE IF EXISTS `tbfachinfo`;
CREATE TABLE IF NOT EXISTS `tbfachinfo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Information` varchar(45) NOT NULL,
  `LehrerID` int(11) NOT NULL,
  `FachID` int(11) NOT NULL,
  `TagID` int(11) NOT NULL,
  `Stunde_Beginn` int(11) NOT NULL,
  `Stunde_Ende` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fkLehrer_idx` (`LehrerID`),
  KEY `fkFach_idx` (`FachID`),
  KEY `fk_tbFachinfo_tbTage_idx` (`TagID`),
  CONSTRAINT `fkFach` FOREIGN KEY (`FachID`) REFERENCES `tbfaecher` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fkLehrer` FOREIGN KEY (`LehrerID`) REFERENCES `tblehrer` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbFachinfo_tbTage` FOREIGN KEY (`TagID`) REFERENCES `tbtage` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tbfachinfo: ~0 rows (ungefähr)
DELETE FROM `tbfachinfo`;
/*!40000 ALTER TABLE `tbfachinfo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbfachinfo` ENABLE KEYS */;


-- Exportiere Struktur von Tabelle dblessoner.tbfaecher
DROP TABLE IF EXISTS `tbfaecher`;
CREATE TABLE IF NOT EXISTS `tbfaecher` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tbfaecher: ~0 rows (ungefähr)
DELETE FROM `tbfaecher`;
/*!40000 ALTER TABLE `tbfaecher` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbfaecher` ENABLE KEYS */;


-- Exportiere Struktur von Tabelle dblessoner.tbfaecherverteilung
DROP TABLE IF EXISTS `tbfaecherverteilung`;
CREATE TABLE IF NOT EXISTS `tbfaecherverteilung` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Stunde` int(11) NOT NULL,
  `Uhrzeit` time NOT NULL,
  `Ende` time NOT NULL,
  `GruppierungsNr` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tbfaecherverteilung: ~0 rows (ungefähr)
DELETE FROM `tbfaecherverteilung`;
/*!40000 ALTER TABLE `tbfaecherverteilung` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbfaecherverteilung` ENABLE KEYS */;


-- Exportiere Struktur von Tabelle dblessoner.tbfaecherverteilungstundenplan
DROP TABLE IF EXISTS `tbfaecherverteilungstundenplan`;
CREATE TABLE IF NOT EXISTS `tbfaecherverteilungstundenplan` (
  `StundenplanID` int(11) NOT NULL,
  `FaecherveteilungID` int(11) NOT NULL,
  PRIMARY KEY (`StundenplanID`,`FaecherveteilungID`),
  KEY `ZuordnungFaechervertieilung_idx` (`FaecherveteilungID`),
  CONSTRAINT `ZuordnungFaechervertieilung` FOREIGN KEY (`FaecherveteilungID`) REFERENCES `tbfaecherverteilung` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `ZuordnungStundenplan` FOREIGN KEY (`StundenplanID`) REFERENCES `tbstundenplan` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tbfaecherverteilungstundenplan: ~0 rows (ungefähr)
DELETE FROM `tbfaecherverteilungstundenplan`;
/*!40000 ALTER TABLE `tbfaecherverteilungstundenplan` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbfaecherverteilungstundenplan` ENABLE KEYS */;


-- Exportiere Struktur von Tabelle dblessoner.tbklasse
DROP TABLE IF EXISTS `tbklasse`;
CREATE TABLE IF NOT EXISTS `tbklasse` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tbklasse: ~0 rows (ungefähr)
DELETE FROM `tbklasse`;
/*!40000 ALTER TABLE `tbklasse` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbklasse` ENABLE KEYS */;


-- Exportiere Struktur von Tabelle dblessoner.tblehrer
DROP TABLE IF EXISTS `tblehrer`;
CREATE TABLE IF NOT EXISTS `tblehrer` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Titel` varchar(45) DEFAULT NULL,
  `Vorname` varchar(45) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Strasse` varchar(45) NOT NULL,
  `Hausnummer` varchar(8) NOT NULL,
  `PLZ` varchar(8) NOT NULL,
  `Ort` varchar(45) NOT NULL,
  `KlasseID` int(11) DEFAULT NULL,
  `AnmeldungID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `KlasseID_idx` (`KlasseID`),
  KEY `AnmeldungID_idx` (`AnmeldungID`),
  CONSTRAINT `AnmeldungID` FOREIGN KEY (`AnmeldungID`) REFERENCES `tbanmeldung` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `KlasseID` FOREIGN KEY (`KlasseID`) REFERENCES `tbklasse` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tblehrer: ~1 rows (ungefähr)
DELETE FROM `tblehrer`;
/*!40000 ALTER TABLE `tblehrer` DISABLE KEYS */;
INSERT INTO `tblehrer` (`ID`, `Titel`, `Vorname`, `Name`, `Strasse`, `Hausnummer`, `PLZ`, `Ort`, `KlasseID`, `AnmeldungID`) VALUES
	(3, NULL, 'Max', 'Mustermann', 'Musterstraße', '1337', '12345', 'Musterhausen', NULL, 2);
/*!40000 ALTER TABLE `tblehrer` ENABLE KEYS */;


-- Exportiere Struktur von Tabelle dblessoner.tbrechte
DROP TABLE IF EXISTS `tbrechte`;
CREATE TABLE IF NOT EXISTS `tbrechte` (
  `ID` int(11) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Beschreibung` varchar(500) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tbrechte: ~3 rows (ungefähr)
DELETE FROM `tbrechte`;
/*!40000 ALTER TABLE `tbrechte` DISABLE KEYS */;
INSERT INTO `tbrechte` (`ID`, `Name`, `Beschreibung`) VALUES
	(0, 'Schueler', 'Ein Schüler'),
	(1, 'Klassensprecher', 'Ein Klassensprecher, Darf daten Hochladen'),
	(2, 'FachLehrer', 'Ein Lehrer ohne eigene Klasse');
/*!40000 ALTER TABLE `tbrechte` ENABLE KEYS */;


-- Exportiere Struktur von Tabelle dblessoner.tbschueler
DROP TABLE IF EXISTS `tbschueler`;
CREATE TABLE IF NOT EXISTS `tbschueler` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Vorname` varchar(45) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Strasse` varchar(45) NOT NULL,
  `Hausnummer` varchar(8) NOT NULL,
  `PLZ` varchar(8) NOT NULL,
  `Ort` varchar(45) NOT NULL,
  `KlasseID` int(11) NOT NULL,
  `AnmeldungID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `KlasseID_idx` (`KlasseID`),
  KEY `AnmeldungID_idx` (`AnmeldungID`),
  CONSTRAINT `Fk_AnmeldungID` FOREIGN KEY (`AnmeldungID`) REFERENCES `tbanmeldung` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbSchueler_KlasseID` FOREIGN KEY (`KlasseID`) REFERENCES `tbklasse` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tbschueler: ~0 rows (ungefähr)
DELETE FROM `tbschueler`;
/*!40000 ALTER TABLE `tbschueler` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbschueler` ENABLE KEYS */;


-- Exportiere Struktur von Tabelle dblessoner.tbstundenplan
DROP TABLE IF EXISTS `tbstundenplan`;
CREATE TABLE IF NOT EXISTS `tbstundenplan` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Klassename` varchar(45) NOT NULL,
  `Datum` date NOT NULL,
  `KlasseID` int(11) NOT NULL,
  `FaecherverteilungID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `KlasseID_idx` (`KlasseID`),
  CONSTRAINT `Fk_KlasseID` FOREIGN KEY (`KlasseID`) REFERENCES `tbklasse` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tbstundenplan: ~0 rows (ungefähr)
DELETE FROM `tbstundenplan`;
/*!40000 ALTER TABLE `tbstundenplan` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbstundenplan` ENABLE KEYS */;


-- Exportiere Struktur von Tabelle dblessoner.tbtage
DROP TABLE IF EXISTS `tbtage`;
CREATE TABLE IF NOT EXISTS `tbtage` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TagInfoID` int(11) NOT NULL,
  `StundenplanID` int(11) NOT NULL,
  `FindetStatt` tinyint(1) NOT NULL,
  `Information` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_tbTage_tbStundenplan_idx` (`StundenplanID`),
  KEY `fk_tbTage_tbTagInfo_idx` (`TagInfoID`),
  CONSTRAINT `fk_tbTage_tbStundenplan` FOREIGN KEY (`StundenplanID`) REFERENCES `tbstundenplan` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbTage_tbTagInfo` FOREIGN KEY (`TagInfoID`) REFERENCES `tbtaginfo` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tbtage: ~0 rows (ungefähr)
DELETE FROM `tbtage`;
/*!40000 ALTER TABLE `tbtage` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbtage` ENABLE KEYS */;


-- Exportiere Struktur von Tabelle dblessoner.tbtaginfo
DROP TABLE IF EXISTS `tbtaginfo`;
CREATE TABLE IF NOT EXISTS `tbtaginfo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(10) NOT NULL,
  `NameKurz` varchar(2) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportiere Daten aus Tabelle dblessoner.tbtaginfo: ~0 rows (ungefähr)
DELETE FROM `tbtaginfo`;
/*!40000 ALTER TABLE `tbtaginfo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbtaginfo` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
";
    }
}