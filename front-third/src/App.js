import './App.css';
import {BrowserRouter, Route, Routes} from "react-router-dom";
import Profile from "./components/Profile/Profile";
import Works from "./components/Works/Works";
import Help from "./components/Help/Help";
import Login from "./components/Login/Login";
import Register from "./components/Register/Register";
import Home from "./components/Home/Home";
import NotFound from "./components/NotFound/NotFound";


function App() {
  return (
      <Routes>
        <Route path="profile" element={<Profile />} />
        <Route path="works" element={<Works />} />
        <Route path="help" element={<Help />} />
        <Route path="login" element={<Login />} />
        <Route path="register" element={<Register />} />
        <Route path="/" element={<Home />} />
        <Route path="*" element={<NotFound />} />
      </Routes>
  );
}

export default App;
