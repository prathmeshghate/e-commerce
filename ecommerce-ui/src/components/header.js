import React from "react";
import "../Css/header.css";
import { BsSearch } from "react-icons/bs";

export default function header() {
  return (
    <div className="header-main">
      <div className="logo-container">
        <img src={require('../static image/ShopKartLogo.png')} alt="abc" className="logo-main" height={100} width={100}/>
      </div>
      <div className="navigation-tags">
        <div className="header-contents">
          <div className="navigation-menu">
            <div className="clothing-container">Clothing</div>
            <div className="electronics-container">Electronics</div>
            <div className="accessories-container">Accessories</div>
          </div>
          <div className="search-container">
            <BsSearch className="search-logo" size={30} />
          </div>
        </div>
      </div>
    </div>
  );
}


