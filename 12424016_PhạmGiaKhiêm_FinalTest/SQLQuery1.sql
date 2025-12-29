CREATE TABLE Subject (
SubjectID int Primary key,
SubjectName nvarchar(50)
);
CREATE TABLE Result (
ResultID int primary key,
StudentName Nvarchar(100),
Score float ,
SubjectID int FOREIGN KEY REFERENCES Subject(SubjectID)
);

INSERT INTO Subject (SubjectID, SubjectName) VALUES
(1, N'Toán'),
(2, N'Vật Lý'),
(3, N'Hóa Học'),
(4, N'Sinh Học'),
(5, N'Tiếng Anh');

INSERT INTO Result (ResultID, StudentName, Score, SubjectID) VALUES
(1, N'Nguyễn Văn An', 8.5, 1),
(2, N'Trần Thị Bình', 7.0, 1),
(3, N'Lê Văn Cường', 6.8, 2),
(4, N'Phạm Thị Dung', 9.0, 2),
(5, N'Hoàng Văn Em', 5.5, 3),
(6, N'Vũ Thị Hoa', 7.8, 3),
(7, N'Đặng Văn Long', 8.2, 4),
(8, N'Bùi Thị Mai', 6.9, 4),
(9, N'Nguyễn Văn Nam', 9.1, 5),
(10, N'Trương Thị Oanh', 7.4, 5);
INSERT INTO Result (ResultID, StudentName, Score, SubjectID) VALUES
(11, N'Nguyễn Văn An', 7.2, 2),
(12, N'Nguyễn Văn An', 8.0, 3),
(13, N'Trần Thị Bình', 6.5, 2),
(14, N'Trần Thị Bình', 7.9, 5),
(15, N'Lê Văn Cường', 8.1, 1),
(16, N'Lê Văn Cường', 6.4, 4),
(17, N'Phạm Thị Dung', 8.7, 3),
(18, N'Phạm Thị Dung', 9.2, 5),
(19, N'Hoàng Văn Em', 6.0, 1),
(20, N'Vũ Thị Hoa', 8.5, 5);

select * from Result

ALTER TABLE Result
DROP CONSTRAINT PK__Result__97690228797D6B4B; 

ALTER TABLE Result
DROP COLUMN ResultID;

ALTER TABLE Result
ADD ResultID INT IDENTITY(1,1) PRIMARY KEY;