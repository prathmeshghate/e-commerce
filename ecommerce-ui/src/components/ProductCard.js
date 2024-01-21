import React from "react";
import "../Css/ProductCard.css"
import { Link } from "react-router-dom/cjs/react-router-dom";

export default function ProductCard({ data }) {
  return (
    <Link to={`/product/${data.productDescription.productDescriptionId}`}>
      <div className="single-product">
        <img
          src={data.productDescription.imagePath}
          alt="jacket"
          className="product-image"
          height={383}
          width={273}
        />
        <div className="product-title">
          {data.productPrimaryDetails.productName}
        </div>
        <div className="product-deal-price">
          RS. {data.productDescription.productPrice}
        </div>
      </div>
    </Link>
  );
}
