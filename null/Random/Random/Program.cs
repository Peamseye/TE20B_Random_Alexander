using System;



ToolBox.WriteCentered(@"  _____                  _                       __  __   _ ");
ToolBox.WriteCentered(@" |  __ \                | |                     / _|/ _  | |");
ToolBox.WriteCentered(@" | |__) |   _ _ __   ___| |__    ______    ___ | |_| |_  | |");
ToolBox.WriteCentered(@" |  ___/ | | | '_ \ / __| '_ \  |______|  / _ \|  _|  _  | |");
ToolBox.WriteCentered(@" | |   | |_| | | | | (__| | | |          | (_) | | | |   |_|");
ToolBox.WriteCentered(@" |_|    \__,_|_| |_|\___|_| |_|           \___/|_| |_|   (_)");


int hp = 100;
int hp2 = 100;

ToolBox.WriteCentered("");
ToolBox.WriteCentered("");

ToolBox.WriteCentered($"Fighter1 : {hp} health");
ToolBox.WriteCentered("");
ToolBox.WriteCentered($"Fighter2 : {hp2} health");

ToolBox.WriteCentered("");
ToolBox.WriteCentered("");
ToolBox.WriteCentered("");


Random generator = new Random();

int damage = generator.Next(1, 51);

Random generator2 = new Random();

int damage2 = generator2.Next(1, 51);


ToolBox.WriteCentered($"Fighter1 punches Fighter2 and Deals {damage} damage!");
ToolBox.WriteCentered($"Fighter2 punches back, and damages Fighter1 for {damage2} damage!");

Console.ReadLine();

Console.Clear();

ToolBox.WriteCentered(@"  _____                  _                       __  __   _ ");
ToolBox.WriteCentered(@" |  __ \                | |                     / _|/ _  | |");
ToolBox.WriteCentered(@" | |__) |   _ _ __   ___| |__    ______    ___ | |_| |_  | |");
ToolBox.WriteCentered(@" |  ___/ | | | '_ \ / __| '_ \  |______|  / _ \|  _|  _  | |");
ToolBox.WriteCentered(@" | |   | |_| | | | | (__| | | |          | (_) | | | |   |_|");
ToolBox.WriteCentered(@" |_|    \__,_|_| |_|\___|_| |_|           \___/|_| |_|   (_)");

ToolBox.WriteCentered("");
ToolBox.WriteCentered("");
ToolBox.WriteCentered("");

ToolBox.WriteCentered($"Fighter1 : {hp - damage2} Health");
ToolBox.WriteCentered($"Fighter2 : {hp2 - damage} Health");

Console.ReadLine();