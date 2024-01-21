import React from "react";
import "../Css/DealOfTheDay.css";
import { Link } from "react-router-dom/cjs/react-router-dom";
import useFetch from "../utils/fetchApi";
import ProductCard from "./ProductCard";
import ReactElasticCarousel from "react-elastic-carousel";

export default function DealOfTheDay() {
  const BASE_URL = "https://localhost:7188/api/deal-of-the-day";
  const { data: res, loading, error } = useFetch(BASE_URL);

  console.log(res);

  const breakPoint = [
    { width: 1, itemsToShow: 1 },
    { width: 550, itemsToShow: 2 },
    { width: 768, itemsToShow: 3 },
    { width: 1200, itemsToShow: 4 },
  ];

  let ProductScreen =
    res && res?.data ? (
      res.data.map((product) => {
        console.log(product);
        return (
          <ProductCard
            key={product.productDescription.productDescriptionId}
            data={product}
          />
        );
      })
    ) : (
      <h1 style={{ color: "white", fontSize: "20px" }}>Loading...</h1>
    );

  return (
    <div className="deals-section">
      <div className="products-slide-container">
        <ReactElasticCarousel breakPoints={breakPoint}>
          {ProductScreen}
        </ReactElasticCarousel>
      </div>
    </div>
  );
}
