




@import url("https://fonts.googleapis.com/css2?family=Lexend:wght@100..900&family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap");
* {
  padding: 0;
  margin: 0;
  font-family: Roboto Lexend;
  box-sizing: border-box;
  text-decoration: none;
}

ul {
  list-style: none;
}

body {
  width: auto;
  height: auto;
}

nav {
  display: flex;
  justify-items: center;
  align-items: center;
  background: white;
  padding: 10px;
  color: black;
  font-family: "Roboto";
  height: 60px;
  max-width: 100%;
  box-shadow: 0 10px 20px -5px rgba(115, 115, 115, 0.75);
  top: 0px;
  position: sticky;
}
nav img {
  width: 70px;
  height: 60px;
}
nav .location_div {
  display: flex;
  align-items: center;
  gap: 3px;
  margin-left: 50px;
}
nav .search_div {
  width: 450px;
  display: flex;
  align-items: center;
  border: 1px solid grey;
  border-radius: 10px;
  padding: 2px;
  margin-left: 100px;
  height: 35px;
  color: rgb(244, 240, 235);
}
nav .search_div .search_icon {
  padding: 5px;
}
nav .search_div .place_holder {
  margin-left: 10px;
  width: 500px;
  height: 20px;
  border: none;
  padding: 5px;
  font-weight: bolder;
}
nav .icons_div {
  display: flex;
  justify-content: center;
  gap: 15px;
  margin-left: 200px;
}
nav .icons_div .logo-size {
  font-size: 25px;
}

.fontAwesome_color {
  color: orangered;
}

.grocaryDisplay {
  display: flex;
  flex-wrap: wrap;
  gap: 33px;
  margin: 50px 30px 0px 30px;
  height: 200px;
  width: 900px;
}
.grocaryDisplay .product {
  margin: 40px 0px 5px 20px;
}
.grocaryDisplay .product .bg {
  background-color: rgb(246, 236, 240);
  border-top-left-radius: 40px;
  border-top-right-radius: 40px;
  border-bottom-left-radius: 2px;
  border-bottom-right-radius: 2px;
}
.grocaryDisplay .product .product_info {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

a > img {
  width: 100px;
}

.slider_1 {
  display: flex;
  height: 250px;
  border-radius: 50px;
  margin: 10px 40px 0px 40px;
}
.slider_1 .slider1_images {
  display: flex;
  width: fit-content;
  height: 250px;
  justify-content: space-between;
  gap: 3px;
}
.slider_1 .slider1_images .slider1_image {
  width: 939px;
  border-radius: 20px;
}

.t {
  display: none;
}

.Declaration_div {
  display: flex;
  gap: 400px;
  align-items: center;
}
.Declaration_div .Declaration {
  font-size: 22px;
  margin: 10px 30px 0px 50px;
}

.Newly_launched {
  height: 240px;
  width: fit-content;
  margin: 5px 40px 0px 40px;
  display: flex;
  overflow: hidden;
}
.Newly_launched .Newly_launched-pro {
  height: 200px;
  width: 400px;
  display: flex;
  gap: 20px;
  padding: 20px 10px;
  margin: 30px 10px 30px 15px;
  border-bottom-right-radius: 1700px;
  border-top-right-radius: 1800px;
  background-color: rgb(232, 225, 226);
}
.Newly_launched .Newly_launched-pro .Notify {
  width: 80px;
  height: 25px;
  margin-left: 80px;
  font-weight: bold;
  border-radius: 20px;
  border: none;
  color: aliceblue;
  background-color: orangered;
}
.Newly_launched .des1 {
  font-size: 18px;
  line-height: 22px;
  font-weight: bold;
}
.Newly_launched .des2 {
  margin-top: 10px;
  line-height: 18px;
}
.Newly_launched .AddToCart {
  width: 80px;
  height: 25px;
  margin-left: 80px;
  font-weight: bold;
  border-radius: 20px;
  border: none;
  margin-bottom: 20px !important;
  color: black;
  background-color: white;
}

.speacial_deals {
  display: flex;
  gap: 10px;
  margin: 13px 60px 0px 60px;
}

.speacial_deals-product {
  width: 220px;
  height: 420px;
  padding: 5px;
}
.speacial_deals-product .speacial_deals_offer {
  width: 100px;
  height: 30px;
  border: 1px solid;
  font-size: 15px;
  padding: 6px;
  color: whitesmoke;
  background-color: rgb(218, 68, 68);
}
.speacial_deals-product .speacial_deals_image {
  height: 240px;
  width: 200px;
  align-self: center;
}
.speacial_deals-product .speacial_deals_description {
  color: rgb(94, 91, 91);
}
.speacial_deals-product .price {
  display: flex;
  gap: 70px;
  color: grey;
  font-weight: bolder;
}
.speacial_deals-product .speacial_deals_button {
  width: 170px;
  height: 25px;
  border-radius: 20px;
  border: 1px white;
  background-color: greenyellow;
  margin-top: 4px;
}
.speacial_deals-product .speacial_arrow {
  margin-top: 150px;
  z-index: 1;
  height: 20px;
  width: 10px;
  position: sticky;
}

.loved_slider {
  margin-top: 30px;
  height: 130px;
}
.loved_slider .loved-brand_image {
  width: 200px;
  height: 100px;
}

.may_like-slider {
  margin: 10px 40px 0px 40px;
  height: 150px;
}
.may_like-slider .may_like {
  display: flex;
  gap: 13px;
}
.may_like-slider .may_like .may_like_image {
  border-radius: 20px;
}

.footer-sec {
  margin: 30px 0px 0px 0px;
  max-width: 100%;
  height: 600px;
  padding: 30px 50px 10px 50px;
  background-color: rgb(244, 240, 235);
}
.footer-sec .contact_details {
  display: flex;
  width: 890px;
  height: 170px;
}
.footer-sec .contact_details .contact_details-part1 {
  width: 296px;
  height: 168px;
}
.footer-sec .contact_details .contact_details-part1 .imp_links-1 {
  display: flex;
  margin-top: 15px;
  line-height: 30px;
  width: 148px;
  font-weight: 700;
  font-size: 18px;
  height: 140px;
}
.footer-sec .contact_details .contact_details-part1 .imp_links-1 .contact_us {
  font-size: 22px;
}
.footer-sec .contact_details .contact_details-part1 .imp_links-1 .contact_us ul .c {
  color: rgb(52, 43, 43);
}
.footer-sec .contact_details .contact_details-part1 .imp_links-1 .email {
  display: flex;
  gap: 4px;
}
.footer-sec .contact_details .contact_details-part1 .imp_links-1 .space_bet {
  line-height: 40px;
}
.footer-sec .contact_details .contact_details-part1 .imp_links-1 .App_store {
  height: 35px;
  width: 120px;
}
.footer-sec .location_sec .loc_search {
  margin-top: 20px;
  display: flex;
  gap: 140px;
}
.footer-sec .location_sec .loc_search .pincodes {
  margin: 10px 0px 20px 0px;
  font-size: 17px;
  text-align: right;
}
.footer-sec .location_sec .loc_search .search_div {
  width: 450px;
  display: flex;
  align-items: center;
  border: 1px solid grey;
  border-radius: 10px;
  padding: 2px;
  margin-left: 40px;
  height: 35px;
  color: rgb(244, 240, 235);
}
.footer-sec .location_sec .loc_search .search_div .search_icon {
  padding: 5px;
}
.footer-sec .location_sec .loc_search .search_div .place_holder {
  margin-left: 10px;
  width: 500px;
  height: 20px;
  border: none;
  padding: 5px;
  font-weight: bolder;
}
.footer-sec .footer_last {
  display: flex;
  font-size: 20px;
  gap: 700px;
}
.footer-sec .footer_last .footer_socialmedia {
  display: flex;
  gap: 10px;
}

.horizontal_line {
  width: 890px;
  border: 1px solid rgb(48, 112, 120);
  margin-bottom: 10px;
}

/*# sourceMappingURL=main1.cs.map */
