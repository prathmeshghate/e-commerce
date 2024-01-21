import React from "react";
import Header from "./components/header";
import "./Css/App.css";
import Home from "./Pages/home";
import {
  BrowserRouter as Router,
  Route,
  Switch,
} from "react-router-dom/cjs/react-router-dom";
import ProductPage from "./Pages/ProductPage";
import ParticularSection from "./Pages/particularSection";

function App() {
  return (
    <Router>
      <div className="App">
        <div className="header-container">
          <Header />
        </div>
        <Switch>
          <Route exact path="/">
            <Home />
          </Route>
          <Route path="/product/:id">
            <ProductPage />
          </Route>
          <ParticularSection path="/:section"/> 
        </Switch>
      </div>
    </Router>
  );
}

export default App;
