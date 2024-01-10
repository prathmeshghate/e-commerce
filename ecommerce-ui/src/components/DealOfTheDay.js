import React from "react";
import "../Css/DealOfTheDay.css";
import { Link } from "react-router-dom/cjs/react-router-dom";

export default function DealOfTheDay() {
  return (
    <Link to="/product">
      <div className="deals-section">
        <div className="products-slide-container">
          <div className="single-product">
            <img
              src={"/images/DummyImage/clothing-section.jpg"}
              alt="jacket"
              className="product-image"
              height={383}
              width={273}
            />
            <div className="product-title">Filled Halfzip Hoodie</div>
            <div className="product-deal-price">RS. 21,200</div>
          </div>
        </div>
      </div>
    </Link>
  );
}
