# TradeCategoryQuestion

TradeCategoryQuestion\TradeCategoryQuestion\bin\Release\net5.0\publish

Question 2: A new category was created called PEP (politically exposed person). Also, a new bool property
IsPoliticallyExposed was created in the ITrade interface. A trade shall be categorized as PEP if
IsPoliticallyExposed is true. Describe in at most 1 paragraph what you must do in your design to account for this
new category.

Add the PEP value in TradeEnum.Category, add a bool property called IsPoliticallyExposed in ITrade interface and implement it in Trade class, change Trade class SetCategory method to set Category property to PEP when IsPoliticallyExposed property is true, and change the program's main method to require the IsPoliticallyExposed information.
