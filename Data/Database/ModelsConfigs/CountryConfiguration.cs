﻿using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Database.ModelsConfigs
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder
                .HasIndex(x => x.NameEn)
                .IsUnique(true);

            builder
                .HasIndex(x => x.NameRu)
                .IsUnique(true);

            builder
                .HasData(Countries());
        }

        public static IEnumerable<Country> Countries()
        {
            yield return new Country(1, "Kazakhstan", "Казахстан");
            yield return new Country(2, "Ukraine", "Украина");
            yield return new Country(3, "Belarus", "Беларусь");
            yield return new Country(4, "Russia", "Россия");
            yield return new Country(5, "Azerbaijan", "Азербайджан");
            yield return new Country(6, "Armenia", "Армения");
            yield return new Country(7, "Georgia", "Грузия");
            yield return new Country(8, "Israel", "Израиль");
            yield return new Country(9, "USA", "Соединенные Штаты Америки");
            yield return new Country(10, "Canada", "Канада");
            yield return new Country(11, "Kyrgyzstan", "Киргизия");
            yield return new Country(12, "Latvia", "Латвия");
            yield return new Country(13, "Lithuania", "Литва");
            yield return new Country(14, "Estonia", "Эстония");
            yield return new Country(15, "Moldova", "Молдова");
            yield return new Country(16, "Tajikistan", "Таджикистан");
            yield return new Country(17, "Turkmenistan", "Туркменистан");
            yield return new Country(18, "Uzbekistan", "Узбекистан");
            yield return new Country(19, "Australia", "Австралия");
            yield return new Country(20, "Austria", "Австрия");
            yield return new Country(21, "Albania", "Албания");
            yield return new Country(22, "Algeria", "Алжир");
            yield return new Country(23, "American Samoa", "Американское Самоа");
            yield return new Country(24, "Anguilla", "Ангилья");
            yield return new Country(25, "Angola", "Ангола");
            yield return new Country(26, "Andorra", "Андорра");
            yield return new Country(27, "Antigua and Barbuda", "Антигуа и Барбуда");
            yield return new Country(28, "Argentina", "Аргентина");
            yield return new Country(29, "Aruba", "Аруба");
            yield return new Country(30, "Afghanistan", "Афганистан");
            yield return new Country(31, "The bahamas", "Багамы");
            yield return new Country(32, "Bangladesh", "Бангладеш");
            yield return new Country(33, "Barbados", "Барбадос");
            yield return new Country(34, "Bahrain", "Бахрейн");
            yield return new Country(35, "Belize", "Белиз");
            yield return new Country(36, "Belgium", "Бельгия");
            yield return new Country(37, "Benin", "Бенин");
            yield return new Country(38, "Bermuda", "Бермудские острова");
            yield return new Country(39, "Bulgaria", "Болгария");
            yield return new Country(40, "Bolivia", "Боливия");
            yield return new Country(41, "Bosnia and Herzegovina", "Босния и Герцеговина");
            yield return new Country(42, "Botswana", "Ботсвана");
            yield return new Country(43, "Brazil", "Бразилия");
            yield return new Country(44, "Brunei Darussalam", "Бруней-Даруссалам");
            yield return new Country(45, "Burkina Faso", "Буркина-Фасо");
            yield return new Country(46, "Burundi", "Бурунди");
            yield return new Country(47, "Butane", "Бутан");
            yield return new Country(48, "Vanuatu", "Вануату");
            yield return new Country(49, "Great Britain", "Великобритания");
            yield return new Country(50, "Hungary", "Венгрия");
            yield return new Country(51, "Venezuela", "Венесуэла");
            yield return new Country(52, "Virgin Islands, British", "Виргинские острова, Британские");
            yield return new Country(53, "Virgin Islands, US", "Виргинские острова, США");
            yield return new Country(54, "East Timor", "Восточный Тимор");
            yield return new Country(55, "Vietnam", "Вьетнам");
            yield return new Country(56, "Gabon", "Габон");
            yield return new Country(57, "Haiti", "Гаити");
            yield return new Country(58, "Guyana", "Гайана");
            yield return new Country(59, "Gambia", "Гамбия");
            yield return new Country(60, "Ghana", "Гана");
            yield return new Country(61, "Guadeloupe", "Гваделупа");
            yield return new Country(62, "Guatemala", "Гватемала");
            yield return new Country(63, "Guinea", "Гвинея");
            yield return new Country(64, "Guinea bissau", "Гвинея - Бисау");
            yield return new Country(65, "Germany", "Германия");
            yield return new Country(66, "Gibraltar", "Гибралтар");
            yield return new Country(67, "Honduras", "Гондурас");
            yield return new Country(68, "Hong Kong", "Гонконг");
            yield return new Country(69, "Grenada", "Гренада");
            yield return new Country(70, "Greenland", "Гренландия");
            yield return new Country(71, "Greece", "Греция");
            yield return new Country(72, "Guam", "Гуам");
            yield return new Country(73, "Denmark", "Дания");
            yield return new Country(74, "Dominica", "Доминика");
            yield return new Country(75, "Dominican Republic", "Доминиканская Респблика");
            yield return new Country(76, "Egypt", "Египет");
            yield return new Country(77, "Zambia", "Замбия");
            yield return new Country(78, "West Sahara", "Западная Сахара");
            yield return new Country(79, "Zimbabwe", "Зимбабве");
            yield return new Country(80, "India", "Индия");
            yield return new Country(81, "Indonesia", "Индонезия");
            yield return new Country(82, "Jordan", "Иордания");
            yield return new Country(83, "Iraq", "Ирак");
            yield return new Country(84, "Iran", "Иран");
            yield return new Country(85, "Ireland", "Ирландия");
            yield return new Country(86, "Iceland", "Исландия");
            yield return new Country(87, "Spain", "Испания");
            yield return new Country(88, "Italy", "Италия");
            yield return new Country(89, "Yemen", "Йемен");
            yield return new Country(90, "Cape Verde", "Кабо-Верде");
            yield return new Country(91, "Cambodia", "Камбоджа");
            yield return new Country(92, "Cameroon", "Камерун");
            yield return new Country(93, "Qatar", "Катар");
            yield return new Country(94, "Kenya", "Кения");
            yield return new Country(95, "Cyprus", "Кипр");
            yield return new Country(96, "Kiribati", "Кирибати");
            yield return new Country(97, "China", "Китай");
            yield return new Country(98, "Colombia", "Колумбия");
            yield return new Country(99, "Comoros", "Коморские острова");
            yield return new Country(100, "Congo", "Конго");
            yield return new Country(101, "Congo Democratic Republic", "Демократическая республика Конго");
            yield return new Country(102, "Costa Rica", "Коста Рика");
            yield return new Country(103, "Cote dʻIvoire", "Берег Слоновой Кости");
            yield return new Country(104, "Cuba", "Куба");
            yield return new Country(105, "Kuwait", "Кувейт");
            yield return new Country(106, "Laos", "Лаос");
            yield return new Country(107, "Lesotho", "Лесото");
            yield return new Country(108, "Liberia", "Либерия");
            yield return new Country(109, "Lebanon", "Ливан");
            yield return new Country(110, "Libya", "Ливия");
            yield return new Country(111, "Liechtenstein", "Лихтенштейн");
            yield return new Country(112, "Luxembourg", "Люксембург");
            yield return new Country(113, "Mauritius", "Маврикий");
            yield return new Country(114, "Mauritania", "Мавритания");
            yield return new Country(115, "Madagascar", "Мадагаскар");
            yield return new Country(116, "Macau", "Макао");
            yield return new Country(117, "Macedonia", "Македония");
            yield return new Country(118, "Malawi", "Малави");
            yield return new Country(119, "Malaysia", "Малайзия");
            yield return new Country(120, "Mali", "Мали");
            yield return new Country(121, "Maldives", "Мальдивы");
            yield return new Country(122, "Malta", "Мальта");
            yield return new Country(123, "Morocco", "Марокко");
            yield return new Country(124, "Martinique", "Мартиника");
            yield return new Country(125, "Marshall Islands", "Маршалловы острова");
            yield return new Country(126, "Mexico", "Мексика");
            yield return new Country(127, "Micronesia, Federated States", "Микронезия, Федеративные Штаты");
            yield return new Country(128, "Mozambique", "Мозамбик");
            yield return new Country(129, "Monaco", "Монако");
            yield return new Country(130, "Mongolia", "Монголия");
            yield return new Country(131, "Montserrat", "Монсеррат");
            yield return new Country(132, "Myanmar", "Мьянма");
            yield return new Country(133, "Namibia", "Намибия");
            yield return new Country(134, "Nauru", "Науру");
            yield return new Country(135, "Nepal", "Непал");
            yield return new Country(136, "Niger", "Нигер");
            yield return new Country(137, "Nigeria", "Нигерия");
            yield return new Country(138, "Curacao", "ликер кюрасо");
            yield return new Country(139, "Netherlands", "Нидерланды");
            yield return new Country(140, "Nicaragua", "Никарагуа");
            yield return new Country(141, "Niue", "Ниуэ");
            yield return new Country(142, "New Zealand", "Новая Зеландия");
            yield return new Country(143, "New Caledonia", "Новая Каледония");
            yield return new Country(144, "Norway", "Норвегия");
            yield return new Country(145, "United Arab Emirates", "Объединенные Арабские Эмираты");
            yield return new Country(146, "Oman", "Оман");
            yield return new Country(147, "Isle Of Man", "Остров Мэн");
            yield return new Country(148, "Norfolk Island", "Остров Норфолк");
            yield return new Country(149, "Cayman Islands", "Каймановы острова");
            yield return new Country(150, "Cook Islands", "Острова Кука");
            yield return new Country(151, "Turks and Caicos Islands", "Острова Теркс и Кайкос");
            yield return new Country(152, "Pakistan", "Пакистан");
            yield return new Country(153, "Palau", "Палау");
            yield return new Country(154, "Palestinian autonomy", "Палестинская автономия");
            yield return new Country(155, "Panama", "Панама");
            yield return new Country(156, "Papua New Guinea", "Папуа -Новая Гвинея");
            yield return new Country(157, "Paraguay", "Парагвай");
            yield return new Country(158, "Peru", "Перу");
            yield return new Country(159, "Pitkern", "Pitkern");
            yield return new Country(160, "Poland", "Польша");
            yield return new Country(161, "Portugal", "Португалия");
            yield return new Country(162, "Puerto rico", "Пуэрто-Рико");
            yield return new Country(163, "Reunion", "воссоединение");
            yield return new Country(164, "Rwanda", "Руанда");
            yield return new Country(165, "Romania", "Румыния");
            yield return new Country(166, "Salvador", "Сальвадор");
            yield return new Country(167, "Samoa", "Самоа");
            yield return new Country(168, "San marino", "Сан - Марино");
            yield return new Country(169, "Sao Tome and Principe", "Сан - Томе и Принсипи");
            yield return new Country(170, "Saudi Arabia", "Саудовская Аравия");
            yield return new Country(171, "Swaziland", "Свазиленд");
            yield return new Country(172, "Saint Helena", "Остров Святой Елены");
            yield return new Country(173, "Democratic People's Republic of Korea", "Корейская Народно-Демократическая Республика");
            yield return new Country(174, "Northern Mariana Islands", "Северные Марианские острова");
            yield return new Country(175, "Seychelles", "Сейшельские острова");
            yield return new Country(176, "Senegal", "Сенегал");
            yield return new Country(177, "St.Vincent", "Сент-Винсент");
            yield return new Country(178, "Saint Kitts and Nevis", "Сент - Китс и Невис");
            yield return new Country(179, "Saint Lucia", "Санкт - Люсия");
            yield return new Country(180, "St.Pierre and Miquelon", "Сен-Пьер и Микелон");
            yield return new Country(181, "Serbia", "Сербия");
            yield return new Country(182, "Singapore", "Сингапур");
            yield return new Country(183, "Syrian Arab Republic", "Сирийская Арабская Республика");
            yield return new Country(184, "Slovakia", "Словакия");
            yield return new Country(185, "Slovenia", "Словения");
            yield return new Country(186, "Solomon islands", "Соломоновы острова");
            yield return new Country(187, "Somalia", "Сомали");
            yield return new Country(188, "Sudan", "Судан");
            yield return new Country(189, "Suriname", "Суринам");
            yield return new Country(190, "Sierra Leone", "Сьерра - Леоне");
            yield return new Country(191, "Thailand", "Таиланд");
            yield return new Country(192, "Taiwan", "Тайвань");
            yield return new Country(193, "Tanzania", "Танзания");
            yield return new Country(194, "Togo", "Того");
            yield return new Country(195, "Tokelau", "Токелау");
            yield return new Country(196, "Tonga", "Тонга");
            yield return new Country(197, "Trinidad and Tobago", "Тринидад и Тобаго");
            yield return new Country(198, "Tuvalu", "Тувалу");
            yield return new Country(199, "Tunisia", "Тунис");
            yield return new Country(200, "Turkey", "Турция");
            yield return new Country(201, "Uganda", "Уганда");
            yield return new Country(202, "Wallis and Futuna", "Уоллис и Футуна");
            yield return new Country(203, "Uruguay", "Уругвай");
            yield return new Country(204, "Faroe islands", "Фарерские острова");
            yield return new Country(205, "Fiji", "Фиджи");
            yield return new Country(206, "Philippines", "Филиппины");
            yield return new Country(207, "Finland", "Финляндия");
            yield return new Country(208, "Falkland islands", "Фолклендские острова");
            yield return new Country(209, "France", "Франция");
            yield return new Country(210, "French Guiana", "Французская Гвиана");
            yield return new Country(211, "French polynesia", "Французская Полинезия");
            yield return new Country(212, "Croatia", "Хорватия");
            yield return new Country(213, "Central African Republic", "Центрально-Африканская Республика");
            yield return new Country(214, "Chad", "Чад");
            yield return new Country(215, "Czech", "Чехия");
            yield return new Country(216, "Chile", "Чили");
            yield return new Country(217, "Switzerland", "Швейцария");
            yield return new Country(218, "Sweden", "Швеция");
            yield return new Country(219, "Svalbard and Jan Mayen", "Шпицберген и Ян Майен");
            yield return new Country(220, "Sri Lanka", "Шри-Ланка");
            yield return new Country(221, "Ecuador", "Эквадор");
            yield return new Country(222, "Equatorial Guinea", "Экваториальная Гвинея");
            yield return new Country(223, "Eritrea", "Эритрея");
            yield return new Country(224, "Ethiopia", "Эфиопия");
            yield return new Country(225, "The Republic of Korea", "Республика Корея");
            yield return new Country(226, "South Africa", "Южная Африка");
            yield return new Country(227, "Jamaica", "Ямайка");
            yield return new Country(228, "Japan", "Япония");
            yield return new Country(229, "Montenegro", "Черногория");
            yield return new Country(230, "Djibouti", "Джибути");
            yield return new Country(231, "South Sudan", "Южный Судан");
            yield return new Country(232, "Vatican", "Ватикан");
            yield return new Country(233, "Sint Maarten", "Синт - Мартен");
            yield return new Country(234, "Bonaire, Sint Eustatius and Saba", "Бонэйр, Синт - Эстатиус и Саба");
        }
    }
}
