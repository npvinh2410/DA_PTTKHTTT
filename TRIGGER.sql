--Them chi tiet dang ky goi tiem
----Cap nhat tong tien cho phieu dang ky
DROP TRIGGER TONG_DK_GOITIEM;

CREATE TRIGGER TONG_DK_GOITIEM AFTER INSERT ON CT_DANGKY_GOITIEM FOR EACH ROW
DECLARE
    TIEN NUMBER;
BEGIN
    SELECT THANHTIEN INTO TIEN FROM GOITIEM GT WHERE :NEW.MAGT=GT.MAGT;
    UPDATE PHIEUDANGKYTIEM PDK  
    SET PDK.TONGTIEN = PDK.TONGTIEN+TIEN WHERE :NEW.MADK= PDK.MADK;
END;

--Them chi tiet goi tiem le
----Cap nhat tong tien cho phieu dang ky
DROP TRIGGER TONG_DK_GOITIEMLE;

CREATE TRIGGER TONG_DK_GOITIEMLE AFTER INSERT ON CT_DANGKY_GOITIEMLE FOR EACH ROW
DECLARE
    TIEN NUMBER;
BEGIN
    SELECT VC.DONGIA INTO TIEN FROM VACXIN VC WHERE :NEW.MAVC=VC.MAVC;
    UPDATE PHIEUDANGKYTIEM PDK  
    SET PDK.TONGTIEN = PDK.TONGTIEN+TIEN WHERE :NEW.MADK= PDK.MADK;
END;

--Cap nhat tong tien cua hoa don khi cap nhat phieu dang ky
DROP TRIGGER TONG_HOADON;

CREATE TRIGGER TONG_HOADON AFTER UPDATE ON PHIEUDANGKYTIEM FOR EACH ROW

BEGIN
    UPDATE HOADON HD  
    SET HD.TONGTIEN = :NEW.TONGTIEN WHERE :NEW.MADK= HD.MADK;
END;

-- Them chi tiet hoa don cho viec them chi tiet dang ky vac xin
DROP TRIGGER CT_HOADON

CREATE TRIGGER CT_HOADON AFTER INSERT ON CT_DANGKY_GOITIEMLE FOR EACH ROW
DECLARE
    MAHDON VARCHAR2(8);
    TIEN NUMBER;
BEGIN
    SELECT VC.DONGIA INTO TIEN FROM VACXIN VC WHERE :NEW.MAVC=VC.MAVC;
    SELECT HD.MAHD INTO MAHDON FROM HOADON HD WHERE HD.MADK=:NEW.MADK;
    INSERT INTO CT_HOADON(MAHD,MAVC,SOLUONG,THANHTIEN) VALUES (MAHDON,:NEW.MAVC,'1',TIEN);
END;

--Tinh tong tien phieu dat mua khi them hoac sua ct_phieudatmua
DROP TRIGGER update_DatMua

create or replace trigger update_DatMua
before insert or update on ct_phieudatmua
for each row
declare
    dongia ct_phieudatmua.dongia%type;
begin
    select dongia into dongia from vacxin where :new.mavc = mavc;
    :new.dongia := dongia;
    :new.thanhtien := dongia*:new.soluong;
    update phieudatmua set tongtien = tongtien + dongia where mapd = :new.mapd;
end;