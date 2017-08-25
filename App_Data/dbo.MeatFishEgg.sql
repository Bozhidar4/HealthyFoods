CREATE TABLE [dbo].[MeatFishEgg] (
    [MeatFishEggID] INT            IDENTITY (1, 1) NOT NULL,
    [Image]         VARCHAR(MAX)        NULL,
    [Name]          NVARCHAR (MAX) NULL,
    [Protein]       FLOAT (53)     NULL,
    [Carbohydrates] FLOAT (53)     NULL,
    [Fat]           FLOAT (53)     NULL,
    [Energy]        FLOAT (53)     NULL,
    [Food_ID]       INT            NULL,
    CONSTRAINT [PK_dbo.MeatFishEgg] PRIMARY KEY CLUSTERED ([MeatFishEggID] ASC),
    CONSTRAINT [FK_dbo.MeatFishEgg_dbo.Food_Food_ID] FOREIGN KEY ([Food_ID]) REFERENCES [dbo].[Food] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Food_ID]
    ON [dbo].[MeatFishEgg]([Food_ID] ASC);

