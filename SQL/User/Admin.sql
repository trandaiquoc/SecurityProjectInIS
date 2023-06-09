ALTER SESSION SET "_ORACLE_SCRIPT"= TRUE; 
DROP USER MNG CASCADE;
CREATE USER MNG IDENTIFIED BY 1 CONTAINER = ALL;
GRANT DBA TO MNG 
GRANT CONNECT TO PUBLIC;
GRANT CREATE SESSION TO PUBLIC;
GRANT CREATE ANY CONTEXT, CREATE PROCEDURE TO MNG;
GRANT EXECUTE ON DBMS_SESSION TO MNG;
GRANT SELECT ANY DICTIONARY TO MNG; 
GRANT EXECUTE ON SYS.DBMS_CRYPTO TO MNG;
GRANT EXECUTE ON SYS.DBMS_RLS TO MNG;
GRANT EXECUTE ON SYS.DBMS_FGA TO MNG;
GRANT ALTER SESSION TO MNG;
GRANT RESOURCE TO MNG;
GRANT UNLIMITED TABLESPACE TO MNG;
