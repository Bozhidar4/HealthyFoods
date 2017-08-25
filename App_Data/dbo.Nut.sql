CREATE TABLE [dbo].[Nut] (
    [NutID]         INT            IDENTITY (1, 1) NOT NULL,
    [Image]         VARCHAR(MAX)        NULL,
    [Name]          NVARCHAR (MAX) NULL,
    [Protein]       FLOAT (53)     NULL,
    [Carbohydrates] FLOAT (53)     NULL,
    [Fat]           FLOAT (53)     NULL,
    [Energy]        FLOAT (53)     NULL,
    [Food_ID]       INT            NULL,
    CONSTRAINT [PK_dbo.Nut] PRIMARY KEY CLUSTERED ([NutID] ASC),
    CONSTRAINT [FK_dbo.Nut_dbo.Food_Food_ID] FOREIGN KEY ([Food_ID]) REFERENCES [dbo].[Food] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Food_ID]
    ON [dbo].[Nut]([Food_ID] ASC);

