import React from "react";
import "../Css/header.css";
import { BiShoppingBag } from "react-icons/bi";
import { BsSearch } from "react-icons/bs";
import { TbShoppingCartCode } from "react-icons/tb";

export default function header() {
  return (
    <div className="header-main">
      <div className="logo-container">
        <div className="shopping-bag">
          <BiShoppingBag size={60} />
        </div>
        <div className="shopping-cart" >
          <TbShoppingCartCode size={35} />
        </div>
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


