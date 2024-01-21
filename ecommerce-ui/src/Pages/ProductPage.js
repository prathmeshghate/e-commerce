import React from "react";
import "../Css/ProductPage.css";
import { TbTruckDelivery } from "react-icons/tb";
import { GiCardboardBoxClosed } from "react-icons/gi";
import { IoPricetag } from "react-icons/io5";
import { useParams } from "react-router-dom/cjs/react-router-dom";

export default function ProductPage() {
  const {id}=useParams();

  return (
    <div className="product-page-container">
      <div className="product-container">
        <div className="product-image-container">
          <div className="selected-image">
            <img
              src="/images/DummyImage/clothing1.jpg"
              alt="abc"
              className="product-display-image"
              height={600}
              width={430}
            />
          </div>
        </div>
        <div className="product-info-container">
          <div className="product-heading">Filled Halfzip Hoodie dsdsdsdafas</div>
          <div className="product-price-container">
            <div className="price-section">RS. 21,200.00</div>
            <div className="tax-note">TAX INCLUDED.</div>
          </div>
          <div className="size-container">
            <div className="size-section-title">Size</div>
            <div className="size-variation">
              <li>Small</li>
              <li>Medium</li>
              <li>Large</li>
            </div>
          </div>
          <div className="color-container">
            <div className="color-section-title">Color</div>
            <div className="color-variation">
              <li>Red</li>
              <li>Green</li>
              <li>Sky Blue</li>
            </div>
          </div>
          <div className="product-description-container">
            <div className="product-desc-title">Product Description</div>
            <div className="product-description">This is product description of the particular product got from api call. This is product description of the particular product got from api callThis is product description of the particular product got from api callThis </div>
          </div>
          <div className="add-cart-container">Add To Cart</div>
        </div>
      </div>
      <div className="delivery-feature-container">
        <div className="delivery-feature">
          <IoPricetag size={70} />
          <div className="delivery-feature-title">Get 10% Off</div>
          <div className="delivery-feature-desc">
            Avail 10% Off on your first purchase. Available at checkout.
          </div>
        </div>
        <div className="delivery-feature">
          <GiCardboardBoxClosed size={80} />
          <div className="delivery-feature-title">
            Easy Exchanges & Returns*
          </div>
          <div className="delivery-feature-desc">
            Not satisfied with the product? Exchange or Return within 14 days of
            delivery.
          </div>
        </div>
        <div className="delivery-feature">
          <TbTruckDelivery size={80} />
          <div className="delivery-feature-title">Free Shipping</div>{" "}
          <div className="delivery-feature-desc">
            Free shipping on all orders. Ships within 48 hours.
          </div>
        </div>
      </div>
    </div>
  );
}
