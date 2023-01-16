Feature: Trendyol
Bimser Çözüm - Test Uzmanı Mülakatı

 
Scenario: Trendyol en düşük fiyatlı ürün listeleme testi
	Given Kullanıcı "https://trendyol.com" sitesini ziyaret eder
	When Kullanıcı çerez politikasını kabul eder
	And Kullanıcı giriş yap butonuna tıklar
	And Kullanıcı aşağıdaki veriler ile giriş yapar:
		| email                  | password      |
		| bimsercase@hotmail.com | bimsercase41! |
	And Kullanıcı arama alanına "laptop" yazar ve ara butonuna tıklar
	And Kullanıcı arama sonucunda gelen ürün listesini "PRICE_BY_ASC" filtrelemesi ile sıralar
	And Kullanıcı sıralamadaki en düşük fiyatlı ürüne tıklar
	And Kullanıcı ürünü sepete ekler 
	Then Kullanıcı sepetteki ürünün en düşük fiyatlı ürün olduğunu doğrular
	And Kullanıcı çıkış yapar 