CREATE TABLE [dbo].[UserInfo] (
    [UserID]   INT           IDENTITY (1, 1) NOT NULL,
    [UserName] VARCHAR (255) NOT NULL,
    [Password] VARCHAR (10)  NOT NULL,
    [IsAdmin]  BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC),
    UNIQUE NONCLUSTERED ([UserName] ASC)
);

CREATE TABLE [dbo].[Designation] (
    [DesID]   INT             IDENTITY (1, 1) NOT NULL,
    [DesName] VARCHAR (255)   NOT NULL,
    [Salary]  DECIMAL (10, 3) NULL,
    PRIMARY KEY CLUSTERED ([DesID] ASC)
);

CREATE TABLE [dbo].[EmployeesInfo] (
    [EmpID]       INT             IDENTITY (1, 1) NOT NULL,
    [EmpName]     VARCHAR (255)   NOT NULL,
    [EmpKey]      VARCHAR (255)   NOT NULL,
    [Gender]      VARCHAR (8)     NOT NULL,
    [PhoneNo]     INT             NOT NULL,
    [Email]       VARCHAR (255)   NOT NULL,
    [JoinedDate]  DATETIME        NOT NULL,
    [IsActive]    BIT             NOT NULL,
    [DesID]       INT             NULL,
    [IsDisabled]  BIT             NOT NULL,
    [WorkingDays] INT             NULL,
    [AbsentDays]  INT             NULL,
    [TotalSalary] DECIMAL (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([EmpID] ASC),
    UNIQUE NONCLUSTERED ([EmpKey] ASC),
    FOREIGN KEY ([DesID]) REFERENCES [dbo].[Designation] ([DesID])
);

CREATE TABLE [dbo].[Resign] (
    [ResID]      INT           IDENTITY (1, 1) NOT NULL,
    [ApplyDate]  VARCHAR (255) NOT NULL,
    [ReasonNote] VARCHAR (255) NOT NULL,
    [IsApproved] BIT           NOT NULL,
    [EmpID]      INT           NULL,
    PRIMARY KEY CLUSTERED ([ResID] ASC),
    FOREIGN KEY ([EmpID]) REFERENCES [dbo].[EmployeesInfo] ([EmpID])
);

