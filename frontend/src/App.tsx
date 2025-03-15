
import './App.css'
import BowlerList from './BowlerList'

function WelcomeHeading() {
  return (
  <>
  <h1>Welcome to Bowler Central</h1>
  <p>This site displays all the information you'd ever want to know about the Marlins and Sharks Bowling Teams!</p>
  </>
  );
}

function App() {
  return (
    <>
      <WelcomeHeading />
      <BowlerList />
    </>
  )
}

export default App
