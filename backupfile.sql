USE [DEMO_HTML]
GO
/****** Object:  Table [dbo].[HTML]    Script Date: 2/28/2023 11:32:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HTML](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TextHtml] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Html]    Script Date: 2/28/2023 11:32:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_Html] @Html ntext
as 
begin 
insert into HTML (TextHtml) values(@Html)
end
GO
