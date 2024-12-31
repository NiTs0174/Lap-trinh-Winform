USE [master]
GO
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'QuanLySinhVien')
    DROP DATABASE QuanLySinhVien;
GO
CREATE DATABASE [QuanLySinhVien]
GO
USE [QuanLySinhVien]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculty](
	[FacultyID] [int] NOT NULL,
	[FacultyName] [nvarchar](200) NOT NULL,
	[TotalProfessor] [int] DEFAULT 0,
 CONSTRAINT [PK_Faculty] PRIMARY KEY CLUSTERED 
(
	[FacultyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [nvarchar](20) NOT NULL,
	[FullName] [nvarchar](200) NOT NULL,
	[AverageScore] [float] NOT NULL,
	[FacultyID] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES (1, N'Công nghệ thông tin',2)
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES (2, N'Ngôn ngữ Anh',2)
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES (6, N'Quản trị kinh doanh',2)
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES (7, N'Công nghệ ô tô',1)
INSERT [dbo].[Faculty] ([FacultyID], [FacultyName], [TotalProfessor]) VALUES (9, N'Kế Toán',1)
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID]) VALUES (N'1611061916', N'Nguyễn Trần Hoàng Lan', 4.5, 1)
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID]) VALUES (N'1711060596', N'Đảm Minh Đức', 10, 1)
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID]) VALUES (N'1811061004', N'Nguyễn Quốc An', 8, 2)
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID]) VALUES (N'2111062201', N'Dương Quốc Minh', 6.5, 6)
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID]) VALUES (N'2111061113', N'Nguyễn Thị B', 5.5, 7)
INSERT [dbo].[Student] ([StudentID], [FullName], [AverageScore], [FacultyID]) VALUES (N'1711061233', N'Trần Văn A', 7, 9)
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Faculty] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculty] ([FacultyID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Faculty]
GO
USE [master]
GO
ALTER DATABASE [QuanLySinhVien] SET  READ_WRITE 
GO
