import { Text } from "./text.model";

export interface User {
    name: string;
    email: string;
    password: string;
    isAdmin: boolean;
    texts: Text[];
  }
  