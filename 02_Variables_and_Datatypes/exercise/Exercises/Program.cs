﻿using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;


            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int raccoonsPlaying = 3;
            int raccoonsLeaving = 2;
            int raccoonsLeftover = raccoonsPlaying - raccoonsLeaving;
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int flowers = 5;
            int bees = 3;
            int extraFlowers = flowers - bees;
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int lonelyPigeon = 1;
            int friendlyPigeon = 1;
            int totalPigeons = lonelyPigeon + friendlyPigeon;
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int owlsSitting = 3;
            int owlsJoining = 2;
            int totalOwls = owlsSitting + owlsJoining;

            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int workingBeaver = 2;
            int swimmingBeaver = 1;
            workingBeaver = workingBeaver - swimmingBeaver;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int toucanInTree = 2;
            int toucanJoining = 1;
            int totalToucans = toucanInTree + toucanJoining;
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int squirrels = 4;
            int nuts = 2;
            int excessSquirrels = squirrels - nuts;
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal quarters = 0.25M;
            decimal dime = 0.1M;
            decimal nickels = 0.1M;
            decimal totalMoney = quarters + dime + nickels;

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int muffinsBrier = 18;
            int muffinsMacAdams = 20;
            int muffinsFlannery = 17;
            int muffinsTotal = (muffinsBrier + muffinsMacAdams + muffinsFlannery);
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoyo = 0.24M;
            decimal whistle = 0.14M;
            decimal toys = yoyo + whistle;
            /*
            13. Mrs. Hilt made 5 Rice Krispies Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */
            int largeMarshmallow = 8;
            int miniMarshmallow = 10;
            int totalMarshmallow = (largeMarshmallow + miniMarshmallow);
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int snowHilt = 29;
            int snowBrecknock = 17;
            int snowDifference = snowHilt - snowBrecknock;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2.50 on a pencil
            case. How much money does she have left?
            */
            decimal startingMoney = 10;
            decimal toyTruck = 3;
            decimal pencil = 2.50M;
            decimal moneyLeft = startingMoney - (pencil + toyTruck);
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int marbleCollection = 16;
            int marblesLost = 7;
            int marblesLeftover = marbleCollection - marblesLost;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int seashellsHolding = 19;
            int seashellsFinal = 25;
            int seashellsNeeded = seashellsFinal - seashellsHolding;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int booksOnShelf = 38;
            int booksAdded = 10;
            int booksTotal = booksOnShelf + booksAdded;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeLegs = 6;
            int beeTotal = 8;
            int beeLegTotal = beeLegs * beeTotal;

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal iceCreamCone = 0.99M;
            decimal iceCreamPurchase = iceCreamCone * 2M;
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int rocksOwned = 64;
            int rocksTotal = 125;
            int additionalRocksNeeded = rocksTotal - rocksOwned;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int marblesOwnedHilt = 38;
            int marblesLostHilt = 15;
            int marblesLeftoverHilt = marblesOwnedHilt - marblesLostHilt;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int milesToConcert = 78;
            int milesDriven = 32;
            int milesLeft = milesToConcert - milesDriven;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int timeSpentShoveling_Morning = 90;
            int timeSpentShoveling_Afternoon = 45;
            int timeSpentShoveling_Total = timeSpentShoveling_Morning + timeSpentShoveling_Afternoon;
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            decimal hotDogCost = 0.5M;
            int hotDogsBought = 6;
            decimal hotDogTotal = hotDogCost * hotDogsBought;
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            int startingMoneyHilt = 50;
            int pencilCost = 7;
            int pencilsBought = (int)startingMoneyHilt / (int)pencilCost;

            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int butterfliesSeen = 33;
            int butterfliesOrange = 20;
            int butterfliesRed = butterfliesSeen - butterfliesOrange;

            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal moneyPaid = 1M;
            decimal candyCost = 0.54m;
            decimal changeRecieved = moneyPaid - candyCost;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int treesPlanted = 13;
            int additionalTreesPlanted = 12;
            int treesTotal = treesPlanted + additionalTreesPlanted;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int dayLengthInHours = 24;
            int daysUntilGrandma = 2;
            int hoursUntilGrandma = dayLengthInHours * daysUntilGrandma;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numberOfCousins = 4;
            int gumPerCousin = 5;
            int gumTotal = numberOfCousins * gumPerCousin;

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal moneyHeldDan = 3.00m;
            decimal candyCostDan = 1.00m;
            decimal moneyLeftDan = moneyHeldDan - candyCostDan;
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boatsOnLake = 5;
            int boatOccupants = 3;
            int peopleOnLake = boatsOnLake * boatOccupants;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int startingLegos = 380;
            int lostLegos = 57;
            int remainingLegos = startingLegos - lostLegos;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int muffinsBakedArthur = 35;
            int muffinsRequestedArthur = 83;
            int muffinsLeftToBakeArthur = muffinsRequestedArthur - muffinsBakedArthur;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int crayonsWilly = 1400;
            int crayonsLucy = 290;
            int crayonDifference = crayonsWilly - crayonsLucy;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersPerPage = 10;
            int stickerPages = 22;
            int stickersTotal = stickersPerPage * stickerPages;
            /*
            39. There are 100 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int cupcakeTotal = 100;
            int cupcakeChildren = 8;
            double cupcakesShared = (double)cupcakeTotal / (double)cupcakeChildren;
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies, how many
            cookies will not be placed in a jar?
            */
            int gingerbreadCookiesTotal = 47;
            int gingerbreadInGlassJar = 6;
            int gingerbreadLeftovers = gingerbreadCookiesTotal % gingerbreadInGlassJar;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received an equal number of croissants,
            how many will be left with Marian?
            */
            int croissantsMade = 59;
            int croissantsNeighbors = 8;
            int croissantsLeftover = croissantsMade % croissantsNeighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int oatmealCookiesPerTray = 12;
            int oatmealCookiesNeeded = 276;
            int oatmealCookieTraysNeeded = oatmealCookiesNeeded / oatmealCookiesPerTray;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int pretzelsMade = 480;
            int pretzelsPerPerson = 12;
            int pretzelsServings = pretzelsMade / pretzelsPerPerson;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int lemonCupcakesMade = 53;
            int lemonCupcakesPerBox = 3;
            int lemonCupcakesBoxesGiven = lemonCupcakesMade / lemonCupcakesPerBox;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int carrotSticksMade = 74;
            int carrotSticksPeopleServed = 12;
            int carrotSticksLeftover = carrotSticksMade % carrotSticksPeopleServed;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int teddyBearsGathered = 98;
            int teddyBearsPerShelf = 7;
            int teddyBearsShelves = teddyBearsGathered / teddyBearsPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int photosPerAlbum = 20;
            int photosTotal = 480;
            int photosAlbumsNeeded = photosTotal / photosPerAlbum;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int tradingCardsFound = 94;
            int tradingCardsPerBox = 8;
            int tradingCardsBoxesFull = tradingCardsFound / tradingCardsPerBox;
            int tradingCardsLeftover = tradingCardsFound % tradingCardsPerBox;
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int booksTotalFather = 210;
            int booksShelvesFather = 10;
            int booksPerShelfFather = booksTotalFather / booksShelvesFather;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            decimal croissantsCristina = 17;
            decimal croissantsCristinaGuests = 7;
            decimal croissantsCristinaPerPerson = croissantsCristina / croissantsCristinaGuests;
            /*
            51. Bill and Jill are house painters. Bill can paint a standard room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 standard rooms?
            Hint: Calculate the rate at which each painter can complete a room (rooms / hour), combine those rates,
            and then divide the total number of rooms to be painted by the combined rate.
            */
            double paintingRateBill = 1 / 2.15;
            double paintingRateJill = 1 / 1.90;
            double roomCount = 5;
            double paintingRate = roomCount / (paintingRateJill + paintingRateBill) ;
            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */
            string firstName = "Grace";
            string lastName = "Hopper";
            string middleInitial = "B";
            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";
            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */
            int trainMilesTravelled = 537;
            int trainMilesTotal = 800;
            int trainMileslefrt = (trainMilesTravelled * 100) / trainMilesTotal;
        }
    }
}
