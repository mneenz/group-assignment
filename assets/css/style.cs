@charset "UTF-8";
/*
Name: Google News SASS
Version: 1.0
*/
/*COLORS*/
/*Colors SASS file*/
/*! MIXIN  */
/*Transitions*/
@-webkit-keyframes moveUp {
  100% {
    -webkit-transform: translateY(0);
    opacity: 1;
  }
}
@keyframes moveUp {
  100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
    opacity: 1;
  }
}
/*Moving up fade in animation*/
.moveUp {
  opacity: 0;
  -webkit-transform: translateY(200px); /*Taken from mixin.scss*/
  transform: translateY(200px); /*Taken from mixin.scss*/
  -moz-transform: translateY(200px); /*Taken from mixin.scss*/
  -moz-animation: moveUp 1s ease forwards; /*Taken from mixin.scss*/
  -webkit-animation: moveUp 1s ease forwards; /*Taken from mixin.scss*/
  animation: moveUp 1s ease forwards; /*Taken from mixin.scss*/
}

/*Buttons*/
.btn {
  float: right;
  position: relative;
  padding: 10px;
  width: auto;
  border-radius: 9px;
  cursor: pointer;
  overflow: hidden;
  box-sizing: border-box;
  background: #2a5db0;
  font-weight: bold;
  color: white !important;
  -webkit-transition: all 0.3s;
  -moz-transition: all 0.3s;
  -ms-transition: all 0.3s;
  -o-transition: all 0.3s;
  transition: all 0.3s;
  /*Taken from mixin.scss*/
}
.btn:hover {
  padding-right: 30px;
  background: #16315e;
}
.btn:before {
  content: "→";
  position: absolute;
  height: 100%;
  font-size: 125%;
  line-height: 2;
  color: #fff;
  -webkit-transition: all 0.3s;
  -moz-transition: all 0.3s;
  transition: all 0.3s;
  right: -20px;
  top: 0;
  opacity: 0;
}
.btn:hover:before {
  right: 8px;
  opacity: 1;
}

/*Mixin SASS file*/
/*! TYPOGRAPHY  */
/* --- Convert percent font sizes to em ---*/
html, .paragraph, #header nav#menu ul li.search input#searchInput, li, p {
  font-family: "Open Sans", sans-serif;
  font-weight: normal;
  margin-top: 10px;
  font-size: 15px;
  font-size: 0.9375rem;
  line-height: 20px;
  line-height: 1.25rem;
  color: black;
}
html strong, html b, .paragraph strong, #header nav#menu ul li.search input#searchInput strong, li strong, .paragraph b, #header nav#menu ul li.search input#searchInput b, li b, p strong, p b {
  font-weight: bold;
}

strong, b {
  font-weight: bold;
}

i, em {
  font-style: italic;
}

ul {
  list-style-type: none;
  list-style-image: none;
}

li {
  list-style-type: none;
  list-style-image: none;
  margin-top: 5px;
}

h1 {
  font-family: "Open Sans", sans-serif;
  font-weight: bold;
  font-size: 30px;
  font-size: 1.875rem;
  line-height: 35px;
  line-height: 2.1875rem;
}

h2 {
  font-family: "Playfair Display", serif;
  font-weight: normal;
  font-size: 20px;
  font-size: 1.25rem;
  line-height: 25px;
  line-height: 1.5625rem;
}

/*------LINKS-----*/
a {
  color: #2a5db0;
  text-decoration: none;
  -webkit-transition: 0.5s;
  -moz-transition: 0.5s;
  -ms-transition: 0.5s;
  -o-transition: 0.5s;
  transition: 0.5s;
  /*Taken fomr mixin.scss*/
  cursor: pointer;
}
a:hover, a:active, a:visited {
  color: #16315e;
  text-decoration: none;
}

/*Fonts SASS file*/
/*! HEADER STYLES */
#header {
  width: 100%;
  height: 130px;
  overflow: hidden;
  background: white;
  display: block;
  /*Breakpoint for when menu can't fit the screen anymore*/
  /*#header h1*/
  /*Close nav#menu*/
}
@media screen and (max-width: 1190px) {
  #header {
    padding: 2%;
    box-sizing: border-box;
    height: auto;
    position: relative;
  }
}
#header #branding {
  padding: 1%;
  box-sizing: border-box;
  height: 100%;
  display: inline-block;
  vertical-align: middle;
  /*Breakpoint for when menu can't fit the screen anymore*/
  /*#bradning img*/
}
@media screen and (max-width: 1190px) {
  #header #branding {
    height: auto;
    width: 20%;
    max-width: 90px;
  }
  #header #branding img {
    height: auto !important;
    width: 100% !important;
  }
}
#header #branding img {
  height: 100%;
  width: auto;
  display: block;
}
#header h1 {
  vertical-align: middle;
  display: inline-block;
}
#header nav#menu {
  display: block;
  width: 100%;
  border-bottom: 1px solid #CCC;
  border-top: 1px solid #CCC;
  /*Breakpoint for when menu can't fit the screen anymore*/
  /*Close @media screen and (max-width: 1190px)*/
  /*Close ul*/
}
@media screen and (max-width: 1190px) {
  #header nav#menu {
    min-width: auto;
    max-height: 0px;
    -webkit-transition: 1s;
    -moz-transition: 1s;
    -ms-transition: 1s;
    -o-transition: 1s;
    transition: 1s;
    /*Taken fomr mixin.scss*/
    /*Open menu*/
  }
  #header nav#menu li {
    display: none !important;
  }
  #header nav#menu.responsive {
    width: 100%;
    max-height: 1000px;
    -webkit-transition: 1s;
    -moz-transition: 1s;
    -ms-transition: 1s;
    -o-transition: 1s;
    transition: 1s;
    /*Taken fomr mixin.scss*/
  }
  #header nav#menu.responsive li:not(:last-child) {
    float: none;
    display: block !important;
    text-align: left;
    padding: 1% 0;
    border-top: 1px solid #CCC;
  }
}
#header nav#menu ul {
  display: block;
  /*Close li*/
}
#header nav#menu ul li {
  display: inline-block;
  vertical-align: middle;
  text-transform: uppercase;
  font-weight: bold;
  margin: 0 1%;
  font-family: "Playfair Display", serif;
  /*Breakpoint for when menu can't fit the screen anymore*/
  /*@media screen and (max-width: 1190px)*/
}
#header nav#menu ul li a.current {
  color: #16315e;
  border-bottom: 2px solid #16315e;
}
#header nav#menu ul li.icon {
  display: none;
}
#header nav#menu ul li.search input#searchInput {
  background-image: url("../searchicon.png");
  background-position: 4px 7px;
  background-repeat: no-repeat;
  width: 113px;
  background-size: 15px auto;
  box-sizing: border-box;
  padding: 5px 5px 5px 22px;
  border: 1px solid #CCC;
  margin-bottom: 12px;
  box-shadow: 0 0 0 transparent;
}
#header nav#menu ul li.search input#searchInput:focus {
  box-shadow: 0 0 5px #2a5db0;
  -webkit-transition: 0.3s;
  -moz-transition: 0.3s;
  -ms-transition: 0.3s;
  -o-transition: 0.3s;
  transition: 0.3s;
}
@media screen and (max-width: 1190px) {
  #header nav#menu ul li.icon {
    float: right;
    display: inline-block !important;
    position: absolute;
    right: 2%;
    top: 30px;
  }
  #header nav#menu ul li.icon a {
    font-size: 20px;
  }
}

/*Close #header*/
/*Header SASS file*/
/*! ARTICLE STYLES */
article#article {
  overflow: hidden;
  position: relative;
  width: 31%;
  float: left;
  margin: 10px 1%;
  max-height: 200px;
  /*Breakpoints for responsive grid system*/
  /*The first and largest article*/
  /*Close .article-0*/
  /*Styling of smallest articles in 'sidebar'*/
  /*Close .info*/
  /*Close .show*/
}
@media (min-width: 461px) and (max-width: 870px) {
  article#article {
    width: 48% !important;
  }
}
@media (max-width: 460px) {
  article#article {
    width: 98% !important;
    max-height: none;
  }
}
article#article.article-0 {
  width: 64%;
  max-height: none;
}
article#article.article-0 .info p {
  color: white;
}
article#article.article-0 .description, article#article.article-0 .btn {
  display: block !important;
  /*Don't show buttons on most articles since it takes a lot of space*/
}
@media (max-width: 460px) {
  article#article.article-0 .description, article#article.article-0 .btn {
    display: none !important;
  }
}
article#article.article-0 .author {
  display: inline-block !important;
}
article#article.article-0 img {
  height: 520px;
  /*Make image shorter on mobile phones*/
}
@media (max-width: 460px) {
  article#article.article-0 img {
    max-height: 200px !important;
  }
}
article#article.article-2, article#article.article-3, article#article.article-4 {
  border-top: 1px solid #CCC;
  padding-top: 10px;
  margin-top: 0;
  height: 86px;
}
article#article.article-2 .img-link, article#article.article-3 .img-link, article#article.article-4 .img-link {
  float: left;
  width: 40%;
  display: block;
  clear: none;
}
article#article.article-2 .img-link img, article#article.article-3 .img-link img, article#article.article-4 .img-link img {
  height: 86px;
}
article#article.article-2 .info, article#article.article-3 .info, article#article.article-4 .info {
  width: 60%;
  float: left;
  background: none;
  position: relative;
  clear: none;
  padding: 0 0 0 3%;
  height: 86px;
}
article#article.article-2 .info .date-author, article#article.article-3 .info .date-author, article#article.article-4 .info .date-author {
  display: none;
}
article#article.article-2 .info h2, article#article.article-3 .info h2, article#article.article-4 .info h2 {
  font-size: 14px;
  font-size: 0.875rem;
  line-height: 16px;
  line-height: 1rem;
  font-weight: 700;
}
article#article.article-2 .info a, article#article.article-3 .info a, article#article.article-4 .info a {
  color: black !important;
}
article#article img {
  display: block;
  overflow: hidden;
  width: 100%;
  object-fit: cover;
  height: 200px;
}
article#article .info {
  width: 100%;
  position: absolute;
  background: rgba(0, 0, 0, 0.5);
  color: white;
  bottom: 0;
  clear: both;
  overflow: hidden;
  box-sizing: border-box;
  padding: 2%;
  display: block;
}
article#article .info .date-author {
  display: block;
  margin-top: 0;
  color: white;
}
article#article .info a {
  color: white;
}
article#article .info .description, article#article .info .btn {
  display: none;
}
article#article.hide {
  opacity: 0;
  position: absolute;
}
article#article.show {
  opacity: 1;
  display: block;
  margin: 10px 1%;
  border-top: none;
  padding-top: 0;
  height: auto;
  opacity: 1;
  -webkit-transition: opacity 1s;
  -moz-transition: opacity 1s;
  -ms-transition: opacity 1s;
  -o-transition: opacity 1s;
  transition: opacity 1s;
  /*Taken fomr mixin.scss*/
  /*Close .info*/
}
article#article.show a.img-link {
  float: none !important;
  width: 100% !important;
  transition: none;
}
article#article.show a.img-link img {
  height: 200px !important;
  transition: none;
}
article#article.show .info {
  width: 100%;
  transition: none;
  position: absolute;
  background: rgba(0, 0, 0, 0.5);
  clear: both;
  padding: 0 2% 2% 2%;
  float: none;
  height: auto;
}
article#article.show .info h2 {
  font-family: "Playfair Display", serif;
  font-weight: normal;
  font-size: 20px;
  font-size: 1.25rem;
  line-height: 25px;
  line-height: 1.5625rem;
  transition: none;
}
article#article.show .info a {
  color: white !important;
}
article#article.show .info .date-author {
  display: block !important;
}

/*Close #article*/
#no-results {
  display: none;
  padding: 2% 0;
}

.weather-widget-io {
  float: right !important;
  width: 31% !important;
  margin: 10px 2% 10px 0px !important;
  height: 520px !important;
  padding: 0px !important;
  overflow: hidden !important;
}

/*Articles SASS file*/
html {
  width: 100%;
  margin: 0;
  border-top: 2px solid #16315e;
}

body {
  width: 90%;
  overflow-x: hidden;
  display: block;
  clear: both;
  padding: 1%;
  box-sizing: border-box;
  font-family: "Playfair Display", serif;
  font-size: 13pt;
  color: black;
}

@media screen and (max-width: 1024px) {
  /*All Devices*/
  html.touch *:hover {
    pointer-events: none !important;
  }
  html, body {
    width: 100% !important;
    margin: 0px !important;
    overflow-x: hidden !important;
    -webkit-text-size-adjust: none; /* Prevent font scaling in landscape */
  }
  body {
    margin: 0 0 20px;
    height: auto;
    min-height: 100%;
  }
}
#content {
  width: 80%;
  margin: 0 auto;
}
@media (max-width: 870px) {
  #content {
    width: 100%;
  }
}

/*------FOOTER-----*/
#footer {
  width: 100%;
}

/*# sourceMappingURL=style.cs.map */
