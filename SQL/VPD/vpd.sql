--TAO VPD BANG NHANVIEN
--FUNCTION
CREATE OR REPLACE 
FUNCTION F_VPD_NHANVIEN (p_schema VARCHAR2, P_OBJECT VARCHAR2)
RETURN VARCHAR2
AS
    USR VARCHAR2(10);
BEGIN 
    USR := SYS_CONTEXT ('USERENV','SESSION_USER');
    RETURN 'MANV = ''' || USR || ''' ';
END;
/
--ADD POLICY
--BEGIN DBMS_RLS.DROP_POLICY('MNG','NHANVIEN', 'P_NV'); END;
BEGIN
    DBMS_RLS.ADD_POLICY 
    (
        object_schema    => 'MNG',
        object_name      => 'UV_NHANVIEN_QL',
        policy_name      => 'P_NV_QL',
        policy_function  => 'F_VPD_NHANVIEN',
        statement_types  => 'SELECT',
        sec_relevant_cols => 'LUONG, PHUCAP',
        sec_relevant_cols_opt => dbms_rls.all_rows
   );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY 
    (
        object_schema    => 'MNG',
        object_name      => 'UV_NHANVIEN_TP',
        policy_name      => 'P_NV_TP',
        policy_function  => 'F_VPD_NHANVIEN',
        statement_types  => 'SELECT',
        sec_relevant_cols => 'LUONG, PHUCAP',
        sec_relevant_cols_opt => dbms_rls.all_rows
   );
END;