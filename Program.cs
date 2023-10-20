using Dio.me_s_C_Sharp_challenge_from_a_parking_lot.models;

// Set the encoding to UTF8 to display accentuation
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 5;
decimal pricePerHour = 2;

Parking parking = new Parking(initialPrice, pricePerHour);
Menu menu = new Menu(parking);
menu.InicializeMenu();
