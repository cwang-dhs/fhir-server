﻿/*************************************************************
    Task Table
**************************************************************/
CREATE TABLE [dbo].[TaskInfo](
	[TaskId] [varchar](64) NOT NULL,
	[QueueId] [varchar](64) NOT NULL,
	[Status] [smallint] NOT NULL,
    [TaskTypeId] [smallint] NOT NULL,
    [RunId] [varchar](50) null,
	[IsCanceled] [bit] NOT NULL,
    [RetryCount] [smallint] NOT NULL,
    [MaxRetryCount] [smallint] NOT NULL,
	[HeartbeatDateTime] [datetime2](7) NULL,
	[InputData] [varchar](max) NOT NULL,
	[TaskContext] [varchar](max) NULL,
    [Result] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE UNIQUE CLUSTERED INDEX IXC_Task on [dbo].[TaskInfo]
(
    TaskId
)
