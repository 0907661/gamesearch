CREATE TABLE [dbo].[MembershipTypes] (
    [Id]               TINYINT  NOT NULL,
    [SignUpFee]        SMALLINT NOT NULL,
    [DurationInMonths] TINYINT  NOT NULL,
    [Name]     VARCHAR(50)  NOT NULL,
    CONSTRAINT [PK_dbo.MembershipTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

