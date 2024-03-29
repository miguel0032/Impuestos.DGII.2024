

INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (1, N'98754321012', N'E310000000001', CAST(200.00 AS Decimal(18, 2)), CAST(36.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (2, N'98754321012', N'E310000000002', CAST(1000.00 AS Decimal(18, 2)), CAST(180.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (4, N'55566677788', N'A310000000001', CAST(500.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (5, N'55566677788', N'A310000000002', CAST(800.00 AS Decimal(18, 2)), CAST(144.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (6, N'99988877766', N'B310000000001', CAST(1500.00 AS Decimal(18, 2)), CAST(270.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (7, N'99988877766', N'B310000000002', CAST(200.00 AS Decimal(18, 2)), CAST(36.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (8, N'11122233344', N'C310000000001', CAST(3000.00 AS Decimal(18, 2)), CAST(540.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (9, N'11122233344', N'C310000000002', CAST(600.00 AS Decimal(18, 2)), CAST(108.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (10, N'77788899900', N'D310000000001', CAST(1200.00 AS Decimal(18, 2)), CAST(216.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (11, N'77788899900', N'D310000000002', CAST(300.00 AS Decimal(18, 2)), CAST(54.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (12, N'44433322211', N'E310000000001', CAST(2500.00 AS Decimal(18, 2)), CAST(450.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (13, N'44433322211', N'E310000000002', CAST(700.00 AS Decimal(18, 2)), CAST(126.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (14, N'66655544433', N'F310000000001', CAST(1800.00 AS Decimal(18, 2)), CAST(324.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (15, N'66655544433', N'F310000000002', CAST(400.00 AS Decimal(18, 2)), CAST(72.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[ComprobantesFiscales] ([id], [rncCedula], [NCF], [monto], [itbis18], [ITBIS]) VALUES (16, NULL, NULL, NULL, NULL, CAST(0.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[ComprobantesFiscales] OFF
GO
INSERT [dbo].[Contribuyentes] ([rncCedula], [nombre], [tipo], [estatus]) VALUES (N'11122233344', N'JOSE MARTINEZ', N'PERSONA FISICA', N'inactivo')
INSERT [dbo].[Contribuyentes] ([rncCedula], [nombre], [tipo], [estatus]) VALUES (N'123456789', N'FARMACIA TU SALUD', N'PERSONA JURIDICA', N'inactivo')
INSERT [dbo].[Contribuyentes] ([rncCedula], [nombre], [tipo], [estatus]) VALUES (N'44433322211', N'RESTAURANTE LA PERLA', N'PERSONA JURIDICA', N'activo')
INSERT [dbo].[Contribuyentes] ([rncCedula], [nombre], [tipo], [estatus]) VALUES (N'55566677788', N'MARIA GOMEZ', N'PERSONA FISICA', N'activo')
INSERT [dbo].[Contribuyentes] ([rncCedula], [nombre], [tipo], [estatus]) VALUES (N'66655544433', N'ANA RODRIGUEZ', N'PERSONA FISICA', N'inactivo')
INSERT [dbo].[Contribuyentes] ([rncCedula], [nombre], [tipo], [estatus]) VALUES (N'77788899900', N'CARLOS SANCHEZ', N'PERSONA FISICA', N'activo')
INSERT [dbo].[Contribuyentes] ([rncCedula], [nombre], [tipo], [estatus]) VALUES (N'98754321012', N'JUAN PEREZ', N'PERSONA FISICA', N'activo')
INSERT [dbo].[Contribuyentes] ([rncCedula], [nombre], [tipo], [estatus]) VALUES (N'99988877766', N'SUPERMERCADO EL AHORRO', N'PERSONA JURIDICA', N'activo')
GO
