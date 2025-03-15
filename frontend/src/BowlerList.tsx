import { useEffect, useState } from "react";
import { bowler } from "./types/bowler.ts";


function BowlerList () {
    const [bowlers, setBowlers] = useState<bowler[]>([]);

    useEffect(() => {
        const fetchBowler = async () => {
            const response = await fetch('https://localhost:5000/api/Bowler');
            const data = await response.json();

            // Filter to only include Marlins or Sharks bowlers
            const filteredBowlers = data.filter(
                (b: bowler) => b.team?.teamName === "Marlins" || b.team?.teamName === "Sharks"
            );

            setBowlers(filteredBowlers);
        };
            fetchBowler();
    }, []); 

    return(
        <>
        <br></br>
        <h2>Bowler Information</h2>
        <br></br>
        <table>
            <thead>
                <tr>
                    <th>Full Name</th>
                    <th>Address</th>
                    <th>Phone Number</th>
                    <th>Team Name</th>
                </tr>
            </thead>
            <tbody>
                {
                    bowlers.map((b) => (
                        <tr key={b.bowlerId}>
                            <td>{b.bowlerFirstName} {b.bowlerMiddleInit} {b.bowlerLastName}</td>
                            <td>{b.bowlerAddress}, {b.bowlerCity}, {b.bowlerState} {b.bowlerZip}</td>
                            <td>{b.bowlerPhoneNumber}</td>
                            <td>{b.team.teamName}</td>
                        </tr>
                    ))}
            </tbody>
        </table>
        </>
    );
}

export default BowlerList;
